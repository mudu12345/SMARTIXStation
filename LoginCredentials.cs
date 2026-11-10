using System;
using System.IO;

namespace WinFormsApp1
{
    public static class LoginCredentials
    {
        private static string filePath = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory,
            "LoginCredentials.txt");

        public static void CreateDefaultCredentials()
        {
            if (!File.Exists(filePath))
            {
                File.WriteAllLines(filePath, new string[]
                {
                    "admin",
                    "admin123"
                });
            }
        }

        public static string GetUsername()
        {
            CreateDefaultCredentials();
            string[] data = File.ReadAllLines(filePath);
            return data[0];
        }

        public static string GetPassword()
        {
            CreateDefaultCredentials();
            string[] data = File.ReadAllLines(filePath);
            return data[1];
        }

        public static void SaveCredentials(string username, string password)
        {
            File.WriteAllLines(filePath, new string[]
            {
                username,
                password
            });
        }
    }
}