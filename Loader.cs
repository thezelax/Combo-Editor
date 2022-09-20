using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Console = Colorful.Console;
using System.Drawing;
using Aspose.Words;

namespace ZLX_Combo_Editor
{
    internal class Loader
    {
        public enum _Modules
        {
            NormalEdit,
            StrongEdit,
            ExtremeEdit,
            Capitalize,
            Decapitalize,
            Randomize,
            Alphabetize,
            DomainFilter,
            CountryFilter,
            UserToEmail,
            EmailToUser,
            CustomAppend,
            PasswordLength,
            EmailLength,
            RemoveCustom,
            SplitDomain,
            RemoveCommon,
        }

        public static void CreateDir()
        {
            foreach (int i in Enum.GetValues(typeof(_Modules)))
            {
                var typeModule = (_Modules)i;
                if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + $"\\Modules\\{i}"))
                {
                    Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + $"\\Modules\\{typeModule}");
                }
            }
        }
        public static void LoadCombo()
        {
            Console.Title = "ZLX-Editor | Loading Combolist";
        }

        public static void KeyReader()
        {
            ConsoleKey cki;

            do
            {
                cki = Console.ReadKey(true).Key;

                switch (cki)
                {
                    case ConsoleKey.D0:
                        Modules.Modules.Module0();
                        break;
                    case ConsoleKey.D1:
                        Modules.Modules.Module1();
                        break;
                    case ConsoleKey.D2:
                        Modules.Modules.Module2();
                        break;
                    case ConsoleKey.D3:
                        Modules.Modules.Module3();
                        break;
                    case ConsoleKey.D4:
                        Modules.Modules.Module4();
                        break;
                    case ConsoleKey.D5:
                        Modules.Modules.Module5();
                        break;
                    case ConsoleKey.D6:
                        Modules.Modules.Module6();
                        break;
                    case ConsoleKey.D7:
                        Modules.Modules.Module7();
                        break;
                    case ConsoleKey.D8:
                        Modules.Modules.Module8();
                        break;
                    case ConsoleKey.D9:
                        Modules.Modules.Module9();
                        break;
                    case ConsoleKey.A:
                        Modules.Modules.ModuleA();
                        break;
                    case ConsoleKey.B:
                        Modules.Modules.ModuleB();
                        break;
                    case ConsoleKey.C:
                        Modules.Modules.ModuleC();
                        break;
                    case ConsoleKey.D:
                        Modules.Modules.ModuleD();
                        break;
                    case ConsoleKey.E:
                        Modules.Modules.ModuleE();
                        break;
                    case ConsoleKey.F:
                        Modules.Modules.ModuleF();
                        break;
                    case ConsoleKey.G:
                        Modules.Modules.ModuleG();
                        break;
                    case ConsoleKey.H:
                        Modules.Modules.ModuleH();
                        break;
                    case ConsoleKey.J:
                        Modules.Modules.ModuleJ();
                        break;
                }
            }
            while (
            cki != ConsoleKey.D0 || 
            cki != ConsoleKey.D1 ||
            cki != ConsoleKey.D2 ||
            cki != ConsoleKey.D3 ||
            cki != ConsoleKey.D4 ||
            cki != ConsoleKey.D5 ||
            cki != ConsoleKey.D6 ||
            cki != ConsoleKey.D7 ||
            cki != ConsoleKey.D8 || 
            cki != ConsoleKey.D9 ||
            cki != ConsoleKey.A ||
            cki != ConsoleKey.B ||
            cki != ConsoleKey.C ||
            cki != ConsoleKey.D ||
            cki != ConsoleKey.E ||
            cki != ConsoleKey.F ||
            cki != ConsoleKey.G ||
            cki != ConsoleKey.H ||
            cki != ConsoleKey.I ||
            cki != ConsoleKey.J
            );
        }
           

        public static class Menu
        {
            public static readonly Color fade1 = Color.FromArgb(245, 110, 250);
            public static readonly Color fade2 = Color.FromArgb(204, 116, 246);
            public static readonly Color fade3 = Color.FromArgb(164, 118, 237);
            public static readonly Color fade4 = Color.FromArgb(126, 118, 223);
            public static readonly Color fade5 = Color.FromArgb(91, 114, 205);
            public static void List()
            {
                Console.WriteLine("[-] Press your Desired Module!\n", fade1);
                Console.WriteLine("[0] Normal Edit \t\t [A] Email:Pass to User:Pass", fade3);
                Console.WriteLine("[1] Strong Edit \t\t [B] Custom Append", fade3);
                Console.WriteLine("[2] Extreme Edit \t\t [C] Password Length", fade3);
                Console.WriteLine("[3] Capitalize \t\t\t [D] Email Length", fade3);
                Console.WriteLine("[4] Decapitalize \t\t [E] Remove Custom", fade3);
                Console.WriteLine("[5] Randomize \t\t\t [F] Split Domain", fade3);
                Console.WriteLine("[6] Alphabetize \t\t [G] Remove Common", fade3);
                Console.WriteLine("[7] Domain Filter \t\t [H] Credits", fade3);
                Console.WriteLine("[8] Country Filter \t\t ", fade3);
                Console.WriteLine("[9] User:Pass to Email:Pass \t [J] Load File ", fade3);
            }
            public static void Interface()
            {

                

                

                                                                       


                Console.Write("\n\t\t\t    ███████╗██╗░░░░░██╗░░██╗  ███████╗██████╗░██╗████████╗░█████╗░██████╗░ \n", fade1);
                Console.Write("\t\t\t    ╚════██║██║░░░░░╚██╗██╔╝  ██╔════╝██╔══██╗██║╚══██╔══╝██╔══██╗██╔══██╗ \n", fade2);
                Console.Write("\t\t\t    ░░███╔═╝██║░░░░░░╚███╔╝░  █████╗░░██║░░██║██║░░░██║░░░██║░░██║██████╔╝\n", fade3);
                Console.Write("\t\t\t    ██╔══╝░░██║░░░░░░██╔██╗░  ██╔══╝░░██║░░██║██║░░░██║░░░██║░░██║██╔══██╗   \n", fade4);
                Console.Write("\t\t\t    ███████╗███████╗██╔╝╚██╗  ███████╗██████╔╝██║░░░██║░░░╚█████╔╝██║░░██║ \n", fade5);
                Console.Write("\t\t\t    ╚══════╝╚══════╝╚═╝░░╚═╝  ╚══════╝╚═════╝░╚═╝░░░╚═╝░░░░╚════╝░╚═╝░░╚═╝ \n", fade5);
                Console.Write("\t\t\t\t\t\t     For Cracked.io by ZLX\n\n\n\n", fade1);
            }
        }
            
    }
}
