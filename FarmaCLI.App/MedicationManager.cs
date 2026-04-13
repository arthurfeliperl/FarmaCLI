namespace FarmaCLI.App;

public class MedicationManager
{
    private readonly List<string> _medications = new();

    public void AddMedication(string name, string time)
    {
        if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(time))
        {
            throw new ArgumentException("Nome do remédio e horário são obrigatórios.");
        }
        _medications.Add($"{name} - {time}");
    }

    public List<string> GetMedications()
    {
        return _medications;
    }
}