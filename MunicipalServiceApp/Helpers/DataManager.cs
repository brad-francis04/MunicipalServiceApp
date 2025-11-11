using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

using Newtonsoft.Json;

namespace MunicipalServicesApp.Helpers
{
    public static class DataManager
    {
        private static readonly string AppDataPath = Path.Combine(Application.StartupPath, "AppData");

        static DataManager()
        {
            if (!Directory.Exists(AppDataPath))
                Directory.CreateDirectory(AppDataPath);
        }

        public static void Save<T>(List<T> data, string filename)
        {
            string path = Path.Combine(AppDataPath, filename);
            File.WriteAllText(path, JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.Indented));
        }

        public static List<T> Load<T>(string filename)
        {
            string path = Path.Combine(AppDataPath, filename);
            if (File.Exists(path))
            {
                return JsonConvert.DeserializeObject<List<T>>(File.ReadAllText(path)) ?? new List<T>();
            }
            return new List<T>();
        }
    }
}