using System;
using System.Configuration;

namespace Lesson8
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                
                //имя
                if (settings["UserName"] == null)
                {
                    settings.Add("UserName", "Лена");
                    Console.WriteLine($"Hello, {settings["UserName"].Value}!");

                }
                else
                {
                    Console.WriteLine($"Hello, {settings["UserName"].Value}!");
                    Console.WriteLine("Введите имя");
                    settings["UserName"].Value = Console.ReadLine();
                }
                if (settings["Age"] == null)
                {
                    settings.Add("Age", "33");
                }
                else
                {
                    Console.WriteLine("Введите возраст");
                    settings["Age"].Value = Console.ReadLine();
                }
                if (settings["occupation"] == null)
                {
                    settings.Add("occupation", "programmer");
                }
                else
                {
                    Console.WriteLine("Введите род деятельности");
                    settings["occupation"].Value = Console.ReadLine();
                }

                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
                
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error writing app settings");
            }
            

        }
    }
}
