using System;
using System.Configuration;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadAllSettings();
            Console.WriteLine("----------------------------");
            AddUpdateAppSettings("Ваш возвраст -", Age());
            AddUpdateAppSettings("Ваше Имя -", Name());
            AddUpdateAppSettings("Ваше место работы -", Work());
            ReadAllSettings();

        }

        static string Name()
        {

            Console.WriteLine("Введите ваше имя - ");
            string Name = Console.ReadLine();
            return Name;
        }
        static string Age()
        {

            Console.WriteLine("Введите ваш возвраст - ");
            string Age = Console.ReadLine();
            return Age;
        }
        static string Work()
        {

            Console.WriteLine("Введите ваше место работы - ");
            string Work = Console.ReadLine();
            return Work;
        }

        static void ReadAllSettings()
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;

                if (appSettings.Count == 0)
                {
                    Console.WriteLine("AppSettings is empty.");
                }
                else
                {
                    foreach (var key in appSettings.AllKeys)
                    {
                        Console.WriteLine("Key: {0} Value: {1}", key, appSettings[key]);
                    }
                }
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error reading app settings");
            }
        }

        static void ReadSetting(string key)
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                string result = appSettings[key] ?? "Not Found";
                Console.WriteLine(result);
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error reading app settings");
            }
        }

        static void AddUpdateAppSettings(string key, string value)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key].Value = value;
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