using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Cnfurikana_thrid_part_WPF.Modules
{
    public static partial class i18n
    {
        public static string phoneticSymbol = GetResource(nameof(PhoneticSymbol));

        private static string importFile = GetResource(nameof(ImportFile));

        private static string settings = GetResource(nameof(Settings));

        private static string selectFileForImport = GetResource(nameof(SelectFileForImport));

        private static string exportFile = GetResource(nameof(ExportFile));

        private static string selectPathForExport = GetResource(nameof(SelectPathForExport));

        private static string languages = GetResource(nameof(Languages));

        private static string back = GetResource(nameof(Back));

        private static string settingCnfurikanaLanguages = GetResource(nameof(SettingCnfurikanaLanguages));

        private static string settingCnfurikanaCharacter = GetResource(nameof(SettingCnfurikanaCharacter));

        private static string sorry = GetResource(nameof(Sorry));

        private static string cnfurikanaCrush = GetResource(nameof(CnfurikanaCrush));

        private static string pleaseProvideInformationToTechnician = GetResource(nameof(PleaseProvideInformationToTechnician));

        private static string errorMessage = GetResource(nameof(ErrorMessage));

        private static string errorStackTrace = GetResource(nameof(ErrorStackTrace));

        private static string copy = GetResource(nameof(Copy));

        public static string PhoneticSymbol
        {
            get => phoneticSymbol;
            set
            {
                phoneticSymbol = value;
                OnStaticPropertyChanged();
            }
        }

        public static string ImportFile
        {
            get => importFile;
            set
            {
                importFile = value;
                OnStaticPropertyChanged();
            }
        }

        public static string Settings
        {
            get => settings;
            set
            {
                settings = value;
                OnStaticPropertyChanged();
            }
        }

        public static string SelectFileForImport
        {
            get => selectFileForImport;
            set
            {
                selectFileForImport = value;
                OnStaticPropertyChanged();
            }
        }

        public static string ExportFile
        {
            get => exportFile;
            set
            {
                exportFile = value;
                OnStaticPropertyChanged();
            }
        }

        public static string SelectPathForExport
        {
            get => selectPathForExport;
            set
            {
                selectPathForExport = value;
                OnStaticPropertyChanged();
            }
        }

        public static string Languages
        {
            get => languages;
            set
            {
                languages = value;
                OnStaticPropertyChanged();
            }
        }

        public static string Back
        {
            get => back;
            set
            {
                back = value;
                OnStaticPropertyChanged();
            }
        }

        public static string SettingCnfurikanaLanguages
        {
            get => settingCnfurikanaLanguages;
            set
            {
                settingCnfurikanaLanguages = value;
                OnStaticPropertyChanged();
            }
        }

        public static string SettingCnfurikanaCharacter
        {
            get => settingCnfurikanaCharacter;
            set
            {
                settingCnfurikanaCharacter = value;
                OnStaticPropertyChanged();
            }
        }

        public static string Sorry
        {
            get => sorry;
            set
            {
                sorry = value;
                OnStaticPropertyChanged();
            }
        }

        public static string CnfurikanaCrush
        {
            get => cnfurikanaCrush;
            set
            {
                cnfurikanaCrush = value;
                OnStaticPropertyChanged();
            }
        }

        public static string PleaseProvideInformationToTechnician
        {
            get => pleaseProvideInformationToTechnician;
            set
            {
                pleaseProvideInformationToTechnician = value;
                OnStaticPropertyChanged();
            }
        }

        public static string ErrorMessage
        {
            get => errorMessage;
            set
            {
                errorMessage = value;
                OnStaticPropertyChanged();
            }
        }

        public static string ErrorStackTrace
        {
            get => errorStackTrace;
            set
            {
                errorStackTrace = value;
                OnStaticPropertyChanged();
            }
        }

        public static string Copy
        {
            get => copy;
            set
            {
                copy = value;
                OnStaticPropertyChanged();
            }
        }

        public static event PropertyChangedEventHandler StaticPropertyChanged;

        private static void OnStaticPropertyChanged([CallerMemberName]
            string propertyName = null)
        {
            StaticPropertyChanged?.Invoke(null, new PropertyChangedEventArgs(propertyName));
        }
    }
}
