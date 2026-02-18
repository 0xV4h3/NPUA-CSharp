using System.Text.Json;

class User
{
    public string? Name { get; set; }
    public int Age { get; set; }
    public string? Email { get; set; }
    public string? Gender { get; set; }
    public DateTime DateOfBirth { get; set; }
}

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nSelect mode:");
            Console.WriteLine("1: Create and serialize new user");
            Console.WriteLine("2: Deserialize user from file");
            Console.WriteLine("3: Exit");
            Console.Write("Enter your choice (1 - 3): ");
            var mode = Console.ReadLine();

            if (mode == "1")
            {
                Console.Write("Enter user name: ");
                var name = Console.ReadLine();

                Console.Write("Enter age: ");
                int age = int.TryParse(Console.ReadLine(), out int tmpAge) ? tmpAge : 0;

                Console.Write("Enter email: ");
                var email = Console.ReadLine();

                Console.Write("Enter gender: ");
                var gender = Console.ReadLine();

                Console.Write("Enter date of birth (yyyy-mm-dd): ");
                var dobInput = Console.ReadLine();
                DateTime dob = DateTime.TryParse(dobInput, out DateTime tmpDob) ? tmpDob : DateTime.MinValue;

                var user = new User
                {
                    Name = name,
                    Age = age,
                    Email = email,
                    Gender = gender,
                    DateOfBirth = dob
                };

                Console.Write("Enter file name to save (without extension): ");
                var fileName = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(fileName)) fileName = "user.json";
                if (!fileName.EndsWith(".json")) fileName += ".json";
                var filePath = Path.Combine(Environment.CurrentDirectory, fileName);

                try
                {
                    var json = JsonSerializer.Serialize(user, new JsonSerializerOptions { WriteIndented = true });
                    File.WriteAllText(filePath, json);
                    Console.WriteLine($"User data has been saved to {fileName}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error while saving file: {ex.Message}");
                }
            }
            else if (mode == "2")
            {
                var directory = Environment.CurrentDirectory;
                var jsonFiles = Directory.GetFiles(directory, "*.json")
                    .Where(f =>
                        !Path.GetFileName(f).EndsWith(".deps.json", StringComparison.OrdinalIgnoreCase) &&
                        !Path.GetFileName(f).EndsWith(".runtimeconfig.json", StringComparison.OrdinalIgnoreCase)
                    )
                    .ToArray();

                if (jsonFiles.Length == 0)
                {
                    Console.WriteLine("No user JSON files found in directory.");
                    continue;
                }

                Console.WriteLine("Select a file to deserialize:");
                for (int i = 0; i < jsonFiles.Length; i++)
                    Console.WriteLine($"{i + 1}: {Path.GetFileName(jsonFiles[i])}");

                Console.Write("Enter file number: ");
                var choiceInput = Console.ReadLine();
                if (int.TryParse(choiceInput, out int fileChoice) &&
                    fileChoice > 0 && fileChoice <= jsonFiles.Length)
                {
                    var selectedFile = jsonFiles[fileChoice - 1];
                    try
                    {
                        var json = File.ReadAllText(selectedFile);
                        var user = JsonSerializer.Deserialize<User>(json);
                        if (user != null && !string.IsNullOrEmpty(user.Name))
                        {
                            Console.WriteLine("User data loaded from file:");
                            Console.WriteLine($"Name: {user.Name}");
                            Console.WriteLine($"Age: {user.Age}");
                            Console.WriteLine($"Email: {user.Email}");
                            Console.WriteLine($"Gender: {user.Gender}");
                            Console.WriteLine($"Date of Birth: {user.DateOfBirth:yyyy-MM-dd}");
                        }
                        else
                        {
                            Console.WriteLine("File does not contain valid user data.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error while loading file: {ex.Message}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid choice.");
                }
            }
            else if (mode == "3")
            {
                Console.WriteLine("Exiting...");
                break;
            }
            else
            {
                Console.WriteLine("Unknown mode selected.");
            }
        }
    }
}