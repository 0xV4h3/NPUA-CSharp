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
            Console.WriteLine("1: Create and serialize new users");
            Console.WriteLine("2: Deserialize user(s) from file");
            Console.WriteLine("3: Exit");
            Console.Write("Enter your choice (1 - 3): ");
            var mode = Console.ReadLine();

            if (mode == "1")
            {
                int userCount = 1;
                Console.Write("How many users do you want to create? ");
                if (!int.TryParse(Console.ReadLine(), out userCount) || userCount <= 0)
                    userCount = 1;

                var users = new List<User>();
                for (int i = 0; i < userCount; i++)
                {
                    Console.WriteLine($"\n--- User #{i + 1} ---");

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

                    users.Add(new User
                    {
                        Name = name,
                        Age = age,
                        Email = email,
                        Gender = gender,
                        DateOfBirth = dob
                    });
                }

                Console.Write("\nEnter file name to save users (without extension): ");
                var fileName = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(fileName)) fileName = "users.json";
                fileName = Path.GetFileNameWithoutExtension(fileName) + ".json";
                var filePath = Path.Combine(Environment.CurrentDirectory, fileName);

                try
                {
                    var json = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
                    File.WriteAllText(filePath, json);
                    Console.WriteLine($"User list has been saved to {fileName}");
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
                        List<User>? users = null;
                        bool loadedAny = false;

                        try
                        {
                            users = JsonSerializer.Deserialize<List<User>>(json);
                            if (users is { Count: > 0 } && users.Any(u => !string.IsNullOrEmpty(u.Name)))
                            {
                                Console.WriteLine($"{users.Count} user(s) loaded from file:\n");
                                for (int i = 0; i < users.Count; i++)
                                {
                                    var user = users[i];
                                    Console.WriteLine($"--- User #{i + 1} ---");
                                    Console.WriteLine($"Name: {user.Name}");
                                    Console.WriteLine($"Age: {user.Age}");
                                    Console.WriteLine($"Email: {user.Email}");
                                    Console.WriteLine($"Gender: {user.Gender}");
                                    Console.WriteLine($"Date of Birth: {user.DateOfBirth:yyyy-MM-dd}");
                                    Console.WriteLine();
                                }
                                loadedAny = true;
                            }
                        }
                        catch (JsonException ex)
                        {
                            //Console.WriteLine("Failed to deserialize as list: " + ex.Message);
                        }

                        if (!loadedAny)
                        {
                            try
                            {
                                var user = JsonSerializer.Deserialize<User>(json);
                                if (user != null && !string.IsNullOrEmpty(user.Name))
                                {
                                    Console.WriteLine("User data loaded from file:");
                                    Console.WriteLine($"Name: {user.Name}");
                                    Console.WriteLine($"Age: {user.Age}");
                                    Console.WriteLine($"Email: {user.Email}");
                                    Console.WriteLine($"Gender: {user.Gender}");
                                    Console.WriteLine($"Date of Birth: {user.DateOfBirth:yyyy-MM-dd}");
                                    loadedAny = true;
                                }
                            }
                            catch (JsonException ex)
                            {
                                //Console.WriteLine("Failed to deserialize as User object: " + ex.Message);
                            }
                        }

                        if (!loadedAny)
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