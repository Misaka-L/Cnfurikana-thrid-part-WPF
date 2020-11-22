using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Cnfurikana_thrid_part_WPF.Modules
{
     class Settings
     {
         public static Settings AppSettings = new Settings();

        public string Lang { get; set; } = "zh_cn";

        public static void SaveSettings()
        {
            var stream = File.CreateText("settings.json");
            stream.Write(JsonConvert.SerializeObject(AppSettings));
            stream.Close();
        }

        public static void LoadSettings()
        {
            string settingsJson = File.ReadAllText("settings.json");
            if (settingsJson == "")
            {
                throw new Exception("Can't load settings.json");
            }

            AppSettings = JsonConvert.DeserializeObject<Settings>(settingsJson);
        }
    }
}
