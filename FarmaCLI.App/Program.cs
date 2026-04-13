using FarmaCLI.App;

var manager = new MedicationManager();

Console.WriteLine("=== FarmaCLI: Controle de Medicamentos ===");
Console.WriteLine("Versão 1.0.0");

while (true)
{
    Console.WriteLine("\n1. Adicionar Remédio");
    Console.WriteLine("2. Listar Remédios");
    Console.WriteLine("3. Sair");
    Console.Write("Escolha uma opção: ");
    
    var option = Console.ReadLine();

    if (option == "1")
    {
        Console.Write("Nome do Remédio: ");
        var name = Console.ReadLine() ?? "";
        Console.Write("Horário (ex: 08:00): ");
        var time = Console.ReadLine() ?? "";
        
        try
        {
            manager.AddMedication(name, time);
            Console.WriteLine("✅ Remédio adicionado com sucesso!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"❌ Erro: {ex.Message}");
        }
    }
    else if (option == "2")
    {
        var meds = manager.GetMedications();
        Console.WriteLine("\n--- Seus Remédios ---");
        if (meds.Count == 0) Console.WriteLine("Nenhum remédio cadastrado.");
        foreach (var med in meds) Console.WriteLine($"- {med}");
    }
    else if (option == "3")
    {
        break;
    }
}
