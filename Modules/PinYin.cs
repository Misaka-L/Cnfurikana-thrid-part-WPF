using System.Diagnostics;
using Microsoft.International.Converters.PinYinConverter;

namespace Cnfurikana_thrid_part_WPF.Modules
{
    class PinYin
    {
        /// <summary>
        /// 获取一个字的拼音
        /// </summary>
        /// <param name="text">字符</param>
        /// <returns>返回该字的第一个拼音</returns>
        public static string GetPinYin(char text)
        {
            string result = "";
            // 防止非中文导致崩溃
            try
            {
                var cc = new ChineseChar(text);
                // 获取第一个拼音并删除音调
                result = cc.Pinyins[0].Remove(cc.Pinyins[0].Length - 1);
            }
            catch { }

            // 转换为小写
            result = result.ToLower();
            return result;
        }

        /// <summary>
        /// 获取音调
        /// </summary>
        /// <param name="text">字符</param>
        /// <returns>返回该字的第一个音调 ToneType</returns>
        public static string GetTone(char text)
        {
            string result = "";
            // 防止非中文导致崩溃
            try
            {
                var cc = new ChineseChar(text);
                // 获取第一个拼音并删除注音
                result = cc.Pinyins[0].Substring(cc.Pinyins[0].Length - 1);
                switch (result)
                {
                    case "1":
                        result = ToneType.Tone1;
                        break;
                    case "2":
                        result = ToneType.Tone2;
                        break;
                    case "3":
                        result = ToneType.Tone3;
                        break;
                    case "4":
                        result = ToneType.Tone4;
                        break;
                    case "5":
                        result = ToneType.None;
                        break;
                }
            }
            catch { }

            return result;
        }
    }
}
