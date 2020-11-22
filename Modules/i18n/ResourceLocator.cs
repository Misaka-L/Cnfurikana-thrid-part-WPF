using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Resources;
using System.Xml;

namespace Cnfurikana_thrid_part_WPF.Modules
{
    public static partial class i18n
    {
        private static IEnumerable<XmlNode> _i18NXmlNodes;

        public static string GetResource(string key)
        {
            if (_i18NXmlNodes == null)
            {
                InitializeXmlNodes("zh_cn");
            }

            return GetValueByKey(key);
        }

        public static void ReloadResource(string Lang)
        {
            InitializeXmlNodes(Lang);
            foreach (var prop in typeof(i18n).GetProperties(BindingFlags.Public | BindingFlags.Static)) prop.SetValue(null, GetValueByKey(prop.Name));
        }

        private static string GetValueByKey(string key)
        {
            return _i18NXmlNodes.First(p => p.Attributes["key"].Value == key).Attributes["value"].Value;
        }

        private static void InitializeXmlNodes(string Lang)
        {
            var fileName = new Uri($"pack://application:,,,/Cnfurikana-thrid-part-WPF;component/Assets/Lang/{Lang.ToLower()}.xml");
            StreamResourceInfo streamResourceInfo;
            try
            {
                streamResourceInfo = Application.GetResourceStream(fileName);
            }
            catch (IOException)
            {
                 streamResourceInfo = Application.GetResourceStream(new Uri("pack://application:,,,/Cnfurikana-thrid-part-WPF;component/Assets/Lang/zh_cn.xml"));
            }

            var xml = new XmlDocument();
            xml.Load(streamResourceInfo?.Stream);
            _i18NXmlNodes = xml.SelectSingleNode("/localization").ChildNodes.Cast<XmlNode>();
        }
    }
}
