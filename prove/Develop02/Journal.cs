using System.ComponentModel.DataAnnotations;
using System.IO;
public class Journal
{

    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("There are no entries to display");
        }
        else
        {
            foreach (Entry entry in _entries)
            {
                entry.Display();
            }
        }
    }

    public void SaveToFile(string file)
    {

        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }

        }


    }

    public void LoadFromFile(string file)
    {
        if (File.Exists(file))
        {
            Console.WriteLine($"cargando archivo {file}");
            Console.WriteLine("*****************************");
            string[] lines = File.ReadAllLines(file);

            //Console.WriteLine($"Líneas encontradas: {lines.Length}");
            if (lines.Length == 0)
            {

                // Console.WriteLine($"Líneas encontradas: {lines.Length}");
                Console.WriteLine($"The journal has {lines.Length} entries, please write a new entry (Choose option 1)");

            }
            else
            {
                foreach (string line in lines)
                {
                    //     Console.WriteLine($"Procesando línea: {line}");
                    string[] parts = line.Split("|"); //delimitador
                    string date = parts[0];
                    string prompt = parts[1];
                    string answer = parts[2];

                    // Mostrar los datos que estamos cargando
                    // Console.WriteLine($"Fecha: {date}, Pregunta: {prompt}, Respuesta: {answer}");

                    Entry entry = new Entry(prompt, answer)
                    {
                        _date = date
                    };

                    _entries.Add(entry);
                    // Console.WriteLine("Entrada agregada con éxito.");
                    entry.Display();
                }
            }


        }
        else
        {
            Console.WriteLine("File does not exist");
        }

    }

}