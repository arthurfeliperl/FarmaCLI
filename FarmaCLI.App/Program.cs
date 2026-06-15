using System;
using System.Threading.Tasks;
using FarmaCLI.App;

class Program
{
    static async Task Main(string[] args)
    {
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
                Console.WriteLine("\n--- Seus Remédios no Banco de Dados ---");
                try
                {
                    // CORREÇÃO: Puxando o dataSource de dentro do manager
                    await using var cmdRead = manager.dataSource.CreateCommand("SELECT Nome, Horario FROM Remedios;");
                    await using var reader = await cmdRead.ExecuteReaderAsync();
                    
                    bool temRemedio = false;
                    while (await reader.ReadAsync())
                    {
                        temRemedio = true;
                        Console.WriteLine($"- {reader.GetString(0)} (Horário: {reader.GetString(1)})");
                    }

                    if (!temRemedio) 
                    {
                        Console.WriteLine("Nenhum remédio cadastrado na nuvem.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"❌ Erro ao buscar no banco: {ex.Message}");
                }
            }
            else if (option == "3")
            {
                Console.WriteLine("Saindo do sistema...");
                break;
            }
            else
            {
                Console.WriteLine("⚠️ Opção inválida!");
            }
        }
    }
}