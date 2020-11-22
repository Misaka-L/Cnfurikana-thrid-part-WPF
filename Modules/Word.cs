using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cnfurikana_thrid_part_WPF.Modules
{
    class Word
    {
        public string Tone { get; set; }
        public string Kana { get; set; }
        public string SourceText { get; set; }
    }

    class ToneType
    {
        public static string None = "";
        public static string Tone1 = "ˉ";
        public static string Tone2 = "ˊ";
        public static string Tone3 = "ˇ";
        public static string Tone4 = "ˋ";
    }
}
