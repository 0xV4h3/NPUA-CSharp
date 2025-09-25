using System;

enum UserRole { Admin, Editor, Viewer }

namespace Laborator4_1
{
    public class UserRoleSwitch
    {
        static void PrintRole(UserRole role)
        {
            switch (role)
            {
                case UserRole.Admin:
                    Console.WriteLine("Full access");
                    break;
                case UserRole.Editor:
                    Console.WriteLine("Can edit content");
                    break;
                case UserRole.Viewer:
                    Console.WriteLine("Read-only access");
                    break;
            }
        }

        public static void Run()
        {
            PrintRole(UserRole.Admin);
            PrintRole(UserRole.Editor);
            PrintRole(UserRole.Viewer);
        }
    }
}
