using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Console = Colorful.Console;
using System.Drawing;
using System.Windows.Forms.VisualStyles;
using Aspose.Words;
using System.Security.AccessControl;

namespace ZLX_Combo_Editor.Modules
{
    internal class Modules
    {
        public static void Module0()
        {
            Console.Clear();
            Loader.Menu.Interface();
            Console.Title = "ZLX-Editor | Module: 0 | Normal Edit";
            Console.WriteLine($"[INFO] Adds [\"!, @, *\"] to the Passwords", Loader.Menu.fade3);
            // Normal Edit

            List<string> List = Writer.WriteInfo.combolist;
            var tempCount = 0;

            foreach (var item in List.ToList())
            {
                tempCount++;
                var line1 = item;
                var line2 = item;
                var line3 = item;
                var edit1 = line1 += "!";
                var edit2 = line2 += "@";
                var edit3 = line3 += "*";
                Writer.WriteInfo.combolist.Add(edit1);
                Writer.WriteInfo.combolist.Add(edit2);
                Writer.WriteInfo.combolist.Add(edit3);
            }

            Console.WriteLine($"[+] Completed! {Writer.WriteInfo.combolist.Count<string>() - tempCount} new lines have been added!", Loader.Menu.fade1);
            Console.WriteLine($"[-] Press Any Key to Return to the Menu!", Loader.Menu.fade2);
            int kLines = Writer.WriteInfo.combolist.Count<string>() / 1000;
            File.WriteAllLines(AppDomain.CurrentDomain.BaseDirectory + $"\\Modules\\{(Loader._Modules)0}\\{Writer.WriteInfo.comboName} {kLines}k NormalEdit.txt", Writer.WriteInfo.combolist);

            Writer.WriteInfo.combolist.Clear();
            Console.ReadKey();
            Console.Clear();
            Loader.Menu.Interface(); Loader.Menu.List(); Loader.LoadCombo();
        }

        public static void Module1()
        {
            Console.Clear();
            Loader.Menu.Interface();
            Console.Title = "ZLX-Editor | Module: 1 | Strong Edit";
            Console.WriteLine($"[INFO] Adds [\"!, @, *, 123, #\"] to the Passwords", Loader.Menu.fade3);
            // Strong Edit

            List<string> List = Writer.WriteInfo.combolist;
            var tempCount = 0;

            foreach (var item in List.ToList())
            {
                tempCount++;
                var line1 = item;
                var line2 = item;
                var line3 = item;
                var line4 = item;
                var line5 = item;
                var edit1 = line1 += "!";
                var edit2 = line2 += "@";
                var edit3 = line3 += "*";
                var edit4 = line4 += "123";
                var edit5 = line5 += "#";
                Writer.WriteInfo.combolist.Add(edit1);
                Writer.WriteInfo.combolist.Add(edit2);
                Writer.WriteInfo.combolist.Add(edit3);
                Writer.WriteInfo.combolist.Add(edit4);
                Writer.WriteInfo.combolist.Add(edit5);
            }

            Console.WriteLine($"[+] Completed! {Writer.WriteInfo.combolist.Count<string>() - tempCount} new lines have been added!", Loader.Menu.fade1);
            Console.WriteLine($"[-] Press Any Key to Return to the Menu!", Loader.Menu.fade2);
            int kLines = Writer.WriteInfo.combolist.Count<string>() / 1000;
            File.WriteAllLines(AppDomain.CurrentDomain.BaseDirectory + $"\\Modules\\{(Loader._Modules)1}\\{Writer.WriteInfo.comboName} {kLines}k StrongEdit.txt", Writer.WriteInfo.combolist);

            Writer.WriteInfo.combolist.Clear();
            Console.ReadKey();
            Console.Clear();
            Loader.Menu.Interface(); Loader.Menu.List(); Loader.LoadCombo();
        }

        public static void Module2()
        {
            Console.Clear();
            Loader.Menu.Interface();
            Console.Title = "ZLX-Editor | Module: 2 | Extreme Edit";
            Console.WriteLine($"[INFO] Adds [\"!, @, *, 123, #, $, %\"] to the Passwords", Loader.Menu.fade3);
            // Extreme Edit

            List<string> List = Writer.WriteInfo.combolist;
            var tempCount = 0;

            foreach (var item in List.ToList())
            {
                tempCount++;
                var line1 = item;
                var line2 = item;
                var line3 = item;
                var line4 = item;
                var line5 = item;
                var line6 = item;
                var line7 = item;
                var edit1 = line1 += "!";
                var edit2 = line2 += "@";
                var edit3 = line3 += "*";
                var edit4 = line4 += "123";
                var edit5 = line5 += "#";
                var edit6 = line6 += "$";
                var edit7 = line7 += "%";
                Writer.WriteInfo.combolist.Add(edit1);
                Writer.WriteInfo.combolist.Add(edit2);
                Writer.WriteInfo.combolist.Add(edit3);
                Writer.WriteInfo.combolist.Add(edit4);
                Writer.WriteInfo.combolist.Add(edit5);
                Writer.WriteInfo.combolist.Add(edit6);
                Writer.WriteInfo.combolist.Add(edit7);
            }

            Console.WriteLine($"[+] Completed! {Writer.WriteInfo.combolist.Count<string>() - tempCount} new lines have been added!", Loader.Menu.fade1);
            Console.WriteLine($"[-] Press Any Key to Return to the Menu!", Loader.Menu.fade2);
            int kLines = Writer.WriteInfo.combolist.Count<string>() / 1000;
            File.WriteAllLines(AppDomain.CurrentDomain.BaseDirectory + $"\\Modules\\{(Loader._Modules)2}\\{Writer.WriteInfo.comboName} {kLines}k ExtremeEdit.txt", Writer.WriteInfo.combolist);

            Writer.WriteInfo.combolist.Clear();
            Console.ReadKey();
            Console.Clear();
            Loader.Menu.Interface(); Loader.Menu.List(); Loader.LoadCombo();
        }

        public static void Module3()
        {
            Console.Clear();
            Loader.Menu.Interface();
            Console.Title = "ZLX-Editor | Module: 3 | Capitalize";
            Console.WriteLine($"[INFO] Capitalizes the first Character of the Password", Loader.Menu.fade3);
            // Extreme Edit

            List<string> List = Writer.WriteInfo.combolist;

            foreach (var item in List.ToList())
            {
                Writer.WriteInfo.combolist.Remove(item);
                var tempstr1 = item.Split(':')[0]; // Email
                var tempstr2 = item.Split(':')[1]; // Pass
                var capital = tempstr2[0].ToString().ToUpper();
                tempstr2 = tempstr2.Remove(0, 1);
                tempstr2 = tempstr2.Insert(0, capital);
                string final = string.Concat(tempstr1 + ":" + tempstr2);
                Writer.WriteInfo.combolist.Add(final);
            }

            Console.WriteLine($"[+] Completed! Capitalized {Writer.WriteInfo.combolist.Count<string>()} passwords!", Loader.Menu.fade1);
            Console.WriteLine($"[-] Press Any Key to Return to the Menu!", Loader.Menu.fade2);
            int kLines = Writer.WriteInfo.combolist.Count<string>() / 1000;
            File.WriteAllLines(AppDomain.CurrentDomain.BaseDirectory + $"\\Modules\\{(Loader._Modules)3}\\{Writer.WriteInfo.comboName} {kLines}k Capitalize.txt", Writer.WriteInfo.combolist);

            Writer.WriteInfo.combolist.Clear();
            Console.ReadKey();
            Console.Clear();
            Loader.Menu.Interface(); Loader.Menu.List(); Loader.LoadCombo();
        }

        public static void Module4()
        {
            Console.Clear();
            Loader.Menu.Interface();
            Console.Title = "ZLX-Editor | Module: 4 | Decapitalize";
            Console.WriteLine($"[INFO] Decapitalizes the whole Password", Loader.Menu.fade3);
            // Extreme Edit

            List<string> List = Writer.WriteInfo.combolist;

            foreach (var item in List.ToList())
            {
                Writer.WriteInfo.combolist.Remove(item);
                var email = item.Split(':')[0];
                var pass = item.Split(':')[1];

                pass = pass.ToLower();
                Writer.WriteInfo.combolist.Add(email + ":" + pass);

            }

            Console.WriteLine($"[+] Completed! Decapitalized {Writer.WriteInfo.combolist.Count<string>()} passwords!", Loader.Menu.fade1);
            Console.WriteLine($"[-] Press Any Key to Return to the Menu!", Loader.Menu.fade2);
            int kLines = Writer.WriteInfo.combolist.Count<string>() / 1000;
            File.WriteAllLines(AppDomain.CurrentDomain.BaseDirectory + $"\\Modules\\{(Loader._Modules)4}\\{Writer.WriteInfo.comboName} {kLines}k Decapitalize.txt", Writer.WriteInfo.combolist);

            Writer.WriteInfo.combolist.Clear();
            Console.ReadKey();
            Console.Clear();
            Loader.Menu.Interface(); Loader.Menu.List(); Loader.LoadCombo();
        }

        public static void Module5()
        {
            Console.Clear();
            Loader.Menu.Interface();
            Console.Title = "ZLX-Editor | Module: 5 | Randomize";
            Console.WriteLine($"[INFO] Randomizes/Shuffles your Combolist", Loader.Menu.fade3);
            // Extreme Edit

            List<string> List = Writer.WriteInfo.combolist;

            Random random = new Random();

            Writer.WriteInfo.combolist = List.OrderBy(a => random.Next()).ToList();
            

            Console.WriteLine($"[+] Completed! Randomized your Combolist!", Loader.Menu.fade1);
            Console.WriteLine($"[-] Press Any Key to Return to the Menu!", Loader.Menu.fade2);
            int kLines = Writer.WriteInfo.combolist.Count<string>() / 1000;
            File.WriteAllLines(AppDomain.CurrentDomain.BaseDirectory + $"\\Modules\\{(Loader._Modules)5}\\{Writer.WriteInfo.comboName} {kLines}k Randomized.txt", Writer.WriteInfo.combolist);

            Writer.WriteInfo.combolist.Clear();
            Console.ReadKey();
            Console.Clear();
            Loader.Menu.Interface(); Loader.Menu.List(); Loader.LoadCombo();
        }
        public static void Module6()
        {
            Console.Clear();
            Loader.Menu.Interface();
            Console.Title = "ZLX-Editor | Module: 6 | Randomize";
            Console.WriteLine($"[INFO] Sorts your Combolist", Loader.Menu.fade3);
            Console.WriteLine($"\n[1] A to Z\n[2] Z to A", Loader.Menu.fade3);

            List<string> List = Writer.WriteInfo.combolist;
            List<string> _List = new List<string>();
            ConsoleKey key;



                key = Console.ReadKey(true).Key;
                ; ; ; ; ; ; ; ; ; ; ;
               if (key == ConsoleKey.D1)
                {
                    var x = List.ToList();
                    x.Sort();
                    List = x.ToList();
                    Writer.WriteInfo.combolist = List;
                } 
                else if (key == ConsoleKey.D2)
                {
                    var x = List.ToList();
                    x.Sort();
                    x.Reverse();
                    List = x.ToList();
                    Writer.WriteInfo.combolist = List;
                }


            Console.WriteLine($"[+] Completed! Sorted your Combolist!", Loader.Menu.fade1);
            Console.WriteLine($"[-] Press Any Key to Return to the Menu!", Loader.Menu.fade2);
            int kLines = Writer.WriteInfo.combolist.Count<string>() / 1000;
            File.WriteAllLines(AppDomain.CurrentDomain.BaseDirectory + $"\\Modules\\{(Loader._Modules)6}\\{Writer.WriteInfo.comboName} {kLines}k Sorted.txt", Writer.WriteInfo.combolist);

            Writer.WriteInfo.combolist.Clear();
            Console.ReadKey();
            Console.Clear();
            Loader.Menu.Interface(); Loader.Menu.List(); Loader.LoadCombo();
        }

        public static void Module7()
        {
            Console.Clear();
            Loader.Menu.Interface();
            Console.Title = "ZLX-Editor | Module: 7 | Domain Filter";
            Console.WriteLine($"[INFO] Filter a specific Domain [Example: yahoo,gmx,ziggo]\n", Loader.Menu.fade3);

            List<string> List = Writer.WriteInfo.combolist;
            List<string> _List = new List<string>();

            Console.Write("[-] Which domain do you want to filter: ", Loader.Menu.fade3);
            string DomainMatch = Console.ReadLine().ToLower();
            var matchcount = 0;

            try
            {
                foreach (string account in List.ToList())
                {

                    var email = account.Split(':')[0]; // test@brazzers.com
                    var domain = email.Split('@')[1].ToLower();

                    if (domain.Contains(DomainMatch))
                    {
                        // remove account cuz no match
                        _List.Add(account);
                        matchcount++;
                    }

                }
            } 
            catch
            {
                
            }
            

            Console.WriteLine($"[+] Completed! Filtered {DomainMatch} and got {matchcount} matches", Loader.Menu.fade1);
            Console.WriteLine($"[-] Press Any Key to Return to the Menu!", Loader.Menu.fade2);
            int kLines = matchcount / 1000;
            File.WriteAllLines(AppDomain.CurrentDomain.BaseDirectory + $"\\Modules\\{(Loader._Modules)7}\\{Writer.WriteInfo.comboName} {kLines}k {DomainMatch}.txt", _List);

            Writer.WriteInfo.combolist.Clear();
            Console.ReadKey();
            Console.Clear();
            Loader.Menu.Interface(); Loader.Menu.List(); Loader.LoadCombo();
        }

        public static void Module8()
        {
            Console.Clear();
            Loader.Menu.Interface();
            Console.Title = "ZLX-Editor | Module: 8 | Country Filter";
            Console.WriteLine($"[INFO] Filter a specific Country [Example: .tr/.bg/.uk/.org]\n", Loader.Menu.fade3);

            List<string> List = Writer.WriteInfo.combolist;
            List<string> _List = new List<string>();

            Console.Write("[-] Which Country do you want to filter: ", Loader.Menu.fade3);
            string countrymatch = Console.ReadLine().ToLower();
            var matchcount = 0;

            try
            {
                foreach (string account in List.ToList())
                {

                    var email = account.Split(':')[0]; // test@pornhub.com
                    var domain = email.Split('@')[1].ToLower();
                    var cc = domain.Split('.')[1].ToLower();

                    if (cc.Contains(countrymatch))
                    {
                        // remove account cuz no match
                        _List.Add(account);
                        matchcount++;
                    }

                }
            }
            catch
            {

            }


            Console.WriteLine($"[+] Completed! Filtered {countrymatch} and got {matchcount} matches", Loader.Menu.fade1);
            Console.WriteLine($"[-] Press Any Key to Return to the Menu!", Loader.Menu.fade2);
            int kLines = matchcount / 1000;
            File.WriteAllLines(AppDomain.CurrentDomain.BaseDirectory + $"\\Modules\\{(Loader._Modules)8}\\{Writer.WriteInfo.comboName} {kLines}k {countrymatch}.txt", _List);

            Writer.WriteInfo.combolist.Clear();
            Console.ReadKey();
            Console.Clear();
            Loader.Menu.Interface(); Loader.Menu.List(); Loader.LoadCombo();
        }

        public static void Module9()
        {
            Console.Clear();
            Loader.Menu.Interface();
            Console.Title = "ZLX-Editor | Module: 9 | User:Pass -> Email:Pass";
            Console.WriteLine($"[INFO] Converts User:Pass to Email Pass using 3 Populair domains.\n", Loader.Menu.fade3);

            List<string> List = Writer.WriteInfo.combolist;
            List<string> _List = new List<string>();

            Random random = new Random();

            try
            {
                foreach (string account in List.ToList())
                {

                    var user = account.Split(':')[0]; // user:pass
                    var pass = account.Split(':')[1];

                    string[] domains = { "@gmail.com", "@yahoo.com", "@hotmail.com" };

                    string rndDomain = domains[random.Next(domains.Length)];

                    user += rndDomain;
                    _List.Add(user + ":" + pass);

                }
            }
            catch
            {

            }


            Console.WriteLine($"[+] Completed! Converted to Email:Password!", Loader.Menu.fade1);
            Console.WriteLine($"[-] Press Any Key to Return to the Menu!", Loader.Menu.fade2);
            int kLines = _List.Count<string>() / 1000;
            File.WriteAllLines(AppDomain.CurrentDomain.BaseDirectory + $"\\Modules\\{(Loader._Modules)9}\\{Writer.WriteInfo.comboName} {kLines}k UserPassToEmailPass.txt", _List);

            Writer.WriteInfo.combolist.Clear();
            Console.ReadKey();
            Console.Clear();
            Loader.Menu.Interface(); Loader.Menu.List(); Loader.LoadCombo();


        }
        public static void ModuleA()
        {
            Console.Clear();
            Loader.Menu.Interface();
            Console.Title = "ZLX-Editor | Module: A | Email:Pass -> User:Pass";
            Console.WriteLine($"[INFO] Converts Email:Pass to User:Pass\n", Loader.Menu.fade3);

            List<string> List = Writer.WriteInfo.combolist;
            List<string> _List = new List<string>();


            try
            {
                foreach (string account in List.ToList())
                {

                    var email = account.Split(':')[0]; // email@allahaiman.com
                    var user = email.Split('@')[0]; // email@pornocuk.com
                    var pass = account.Split(':')[1];

                    _List.Add(user + ":" + pass);

                }
            }
            catch
            {

            }


            Console.WriteLine($"[+] Completed! Converted to User:Pass!", Loader.Menu.fade1);
            Console.WriteLine($"[-] Press Any Key to Return to the Menu!", Loader.Menu.fade2);
            int kLines = _List.Count<string>() / 1000;
            File.WriteAllLines(AppDomain.CurrentDomain.BaseDirectory + $"\\Modules\\{(Loader._Modules)10}\\{Writer.WriteInfo.comboName} {kLines}k EmailPassToUserPass.txt", _List);

            Writer.WriteInfo.combolist.Clear();
            Console.ReadKey();
            Console.Clear();
            Loader.Menu.Interface(); Loader.Menu.List(); Loader.LoadCombo();
        }

        public static void ModuleB()
        {
            Console.Clear();
            Loader.Menu.Interface();
            Console.Title = "ZLX-Editor | Module: B | Custom Append";
            Console.WriteLine($"[INFO] Appends a string/char at the end of Pass [Exmaple: %,*,!] \n", Loader.Menu.fade3);

            List<string> List = Writer.WriteInfo.combolist;
            List<string> _List = new List<string>();

            Console.Write("[-] What do you want to append: ", Loader.Menu.fade3);
            string append = Console.ReadLine().ToLower();


            try
            {
                foreach (string account in List.ToList())
                {
                    var line = account;
                    line = line + append;
                    _List.Add(append);

                }
            }
            catch
            {

            }


            Console.WriteLine($"[+] Completed! Added Custom Append!", Loader.Menu.fade1);
            Console.WriteLine($"[-] Press Any Key to Return to the Menu!", Loader.Menu.fade2);
            int kLines = _List.Count<string>() / 1000;
            File.WriteAllLines(AppDomain.CurrentDomain.BaseDirectory + $"\\Modules\\{(Loader._Modules)11}\\{Writer.WriteInfo.comboName} {kLines}k CustomAppend.txt", _List);

            Writer.WriteInfo.combolist.Clear();
            Console.ReadKey();
            Console.Clear();
            Loader.Menu.Interface(); Loader.Menu.List(); Loader.LoadCombo();


        }
        public static void ModuleC()
        {
            Console.Clear();
            Loader.Menu.Interface();
            Console.Title = "ZLX-Editor | Module: C | Custom Password Length";
            Console.WriteLine($"[INFO] Filters passwords higher than 'x' characters\n", Loader.Menu.fade3);

            List<string> List = Writer.WriteInfo.combolist;
            List<string> _List = new List<string>();

            Console.Write("[-] Minimum password length: ", Loader.Menu.fade3);
            int pLength = Convert.ToInt32(Console.ReadLine());
            int matchc = 0;

            try
            {
                foreach (string account in List.ToList())
                {
                    var user = account.Split(':')[0];
                    var pass = account.Split(':')[1];

                    if (pass.Length >= pLength)
                    {
                        _List.Add(account);
                        matchc++;
                    }
                }
            }
            catch
            {

            }


            Console.WriteLine($"[+] Completed! Found {matchc} matches!", Loader.Menu.fade1);
            Console.WriteLine($"[-] Press Any Key to Return to the Menu!", Loader.Menu.fade2);
            int kLines = _List.Count<string>() / 1000;
            File.WriteAllLines(AppDomain.CurrentDomain.BaseDirectory + $"\\Modules\\{(Loader._Modules)12}\\{Writer.WriteInfo.comboName} {kLines}k PassLength.txt", _List);

            Writer.WriteInfo.combolist.Clear();
            Console.ReadKey();
            Console.Clear();
            Loader.Menu.Interface(); Loader.Menu.List(); Loader.LoadCombo();

        }

        public static void ModuleD()
        {
            Console.Clear();
            Loader.Menu.Interface();
            Console.Title = "ZLX-Editor | Module: D | Custom Email Length";
            Console.WriteLine($"[INFO] Filters Emails higher than 'x' characters\n", Loader.Menu.fade3);

            List<string> List = Writer.WriteInfo.combolist;
            List<string> _List = new List<string>();

            Console.Write("[-] Minimum email length: ", Loader.Menu.fade3);
            int pLength = Convert.ToInt32(Console.ReadLine());
            int matchc = 0;

            try
            {
                foreach (string account in List.ToList())
                {
                    var email = account.Split(':')[0];
                    var user = email.Split('@')[0];
                    var pass = account.Split(':')[1];

                    if (user.Length >= pLength)
                    {
                        _List.Add(account);
                        matchc++;
                    }
                }
            }
            catch
            {

            }


            Console.WriteLine($"[+] Completed! Found {matchc} matches!", Loader.Menu.fade1);
            Console.WriteLine($"[-] Press Any Key to Return to the Menu!", Loader.Menu.fade2);
            int kLines = _List.Count<string>() / 1000;
            File.WriteAllLines(AppDomain.CurrentDomain.BaseDirectory + $"\\Modules\\{(Loader._Modules)13}\\{Writer.WriteInfo.comboName} {kLines}k EmailLength.txt", _List);

            Writer.WriteInfo.combolist.Clear();
            Console.ReadKey();
            Console.Clear();
            Loader.Menu.Interface(); Loader.Menu.List(); Loader.LoadCombo();
        }

        public static void ModuleE()
        {
            Console.Clear();
            Loader.Menu.Interface();
            Console.Title = "ZLX-Editor | Module: E | Remove Custom Character";
            Console.WriteLine($"[INFO] Remove a specific character from password.\n", Loader.Menu.fade3);

            List<string> List = Writer.WriteInfo.combolist;
            List<string> _List = new List<string>();

            Console.Write("[-] Which character to remove from password: ", Loader.Menu.fade3);
            string customc = Console.ReadLine();
            int matchc = 0;

            try
            {
                foreach (string account in List.ToList())
                {
                    var email = account.Split(':')[0];
                    var pass = account.Split(':')[1];

                    if (pass.Contains(customc)) 
                    {
                        matchc++;
                        pass = pass.Replace(customc, string.Empty);
                    }

                    _List.Add(email + ":" + pass);
                }
            }
            catch
            {

            }


            Console.WriteLine($"[+] Completed! Done found {matchc} matches with char {customc}!", Loader.Menu.fade1);
            Console.WriteLine($"[-] Press Any Key to Return to the Menu!", Loader.Menu.fade2);
            int kLines = _List.Count<string>() / 1000;
            File.WriteAllLines(AppDomain.CurrentDomain.BaseDirectory + $"\\Modules\\{(Loader._Modules)14}\\{Writer.WriteInfo.comboName} {kLines}k CustomRemove.txt", _List);
            Writer.WriteInfo.combolist.Clear();
            Console.ReadKey();
            Console.Clear();
            Loader.Menu.Interface(); Loader.Menu.List(); Loader.LoadCombo();
        }

        public static void ModuleF()
        {
            Console.Clear();
            Loader.Menu.Interface();
            Console.Title = "ZLX-Editor | Module: F | Sort Domain";
            Console.WriteLine($"[INFO] Sorts domain and saves into custom .txt file.\n", Loader.Menu.fade3);

            List<string> List = Writer.WriteInfo.combolist;
            List<string> _List = new List<string>();

            int matchc = 0;

            try
            {
                foreach (string account in List.ToList())
                {
                    var email = account.Split(':')[0];
                    var pass = account.Split(':')[1];
                    var domain = email.Split('@')[1].ToLower();
                    var domainfixed = domain.Split('.')[0].ToLower();

                    if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory + $"\\Modules\\{(Loader._Modules)15}\\{domainfixed}.txt"))
                    {
                        matchc++;
                        var x = File.Create(AppDomain.CurrentDomain.BaseDirectory + $"\\Modules\\{(Loader._Modules)15}\\{domainfixed}.txt");
                        x.Close();
                        Console.WriteLine($"[+] File Created for Domain: {domainfixed}", Loader.Menu.fade3);
                    }

                    File.AppendAllText(AppDomain.CurrentDomain.BaseDirectory + $"\\Modules\\{(Loader._Modules)15}\\{domainfixed}.txt", account + Environment.NewLine);
                }
            }
            catch (Exception ex)
            {
               //Console.WriteLine(ex.ToString()); //Bunun Ne sike Yaradığını Anlatmama gerek yok heralde amk
            }


            Console.WriteLine($"[+] Completed! Created {matchc} different text files!", Loader.Menu.fade1);
            Console.WriteLine($"[-] Press Any Key to Return to the Menu!", Loader.Menu.fade2);
            int kLines = _List.Count<string>() / 1000;
            Writer.WriteInfo.combolist.Clear();
            Console.ReadKey();
            Console.Clear();
            Loader.Menu.Interface(); Loader.Menu.List(); Loader.LoadCombo();
        }

        public static void ModuleG()
        {
            Console.Clear();
            Loader.Menu.Interface();
            Console.Title = "ZLX-Editor | Module: G | Remove Common Passwords";
            Console.WriteLine($"[INFO] Removes lines with common passwords\n", Loader.Menu.fade3);

            List<string> List = Writer.WriteInfo.combolist;
            List<string> _List = new List<string>();

            string[] common = { "123456", "password", "12345678", "qwerty", "123456789", "12345", "1234", "111111", "1234567", "dragon", "123123", "baseball", "abc123", "football", "monkey", "letmein", "696969", "shadow", "master", "666666", "qwertyuiop", "123321", "mustang", "1234567890", "michael", "654321", "pussy", "superman", "1qaz2wsx", "7777777", "fuckyou", "121212", "000000", "qazwsx", "123qwe", "killer", "trustno1", "jordan", "jennifer", "zxcvbnm", "asdfgh", "hunter", "buster", "soccer", "harley", "batman", "andrew", "tigger", "sunshine", "iloveyou", "fuckme", "2000", "charlie", "robert", "thomas", "hockey", "ranger", "daniel", "starwars", "klaster", "112233", "george", "asshole", "computer", "michelle", "jessica", "pepper", "1111", "zxcvbn", "555555", "11111111", "131313", "freedom", "777777", "pass", "fuck", "maggie", "159753", "aaaaaa", "ginger", "princess", "joshua", "cheese", "amanda", "summer", "love", "ashley", "6969", "nicole", "chelsea", "biteme", "matthew", "access", "yankees", "987654321", "dallas", "austin", "thunder", "taylor", "matrix" };
            int matchc = 0;

            try
            {
                foreach (string account in List.ToList())
                {
                    var email = account.Split(':')[0];
                    var pass = account.Split(':')[1];

                    if (Array.IndexOf(common, pass) >= 0)
                    {
                        matchc++;
                    } else
                    {
                        _List.Add(account);
                    }

                }
            }
            catch
            {

            }


            Console.WriteLine($"[+] Completed! Done found {matchc} matches with a common password!", Loader.Menu.fade1);
            Console.WriteLine($"[-] Press Any Key to Return to the Menu!", Loader.Menu.fade2);
            int kLines = _List.Count<string>() / 1000;
            File.WriteAllLines(AppDomain.CurrentDomain.BaseDirectory + $"\\Modules\\{(Loader._Modules)16}\\{Writer.WriteInfo.comboName} {kLines}k CustomRemove.txt", _List);
            Writer.WriteInfo.combolist.Clear();
            Console.ReadKey();
            Console.Clear();
            Loader.Menu.Interface(); Loader.Menu.List(); Loader.LoadCombo();
        }

        public static void ModuleH()
        {
            Console.WriteLine("\nMade by Zelax With <3 | Discord: Zelax#1337", Loader.Menu.fade1);
            Console.ReadKey();
            Console.Clear();
            Loader.Menu.Interface(); Loader.Menu.List(); Loader.LoadCombo();
        }

        public static void ModuleJ()
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                ofd.FilterIndex = 2;
                ofd.RestoreDirectory = true;
                ofd.Title = "Open your Combolist!";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Writer.WriteInfo.comboName = ofd.SafeFileName;
                    var combos = File.ReadAllLines(ofd.FileName);
                    var combocount = 0;

                    foreach (string line in combos)
                    {
                        combocount++;
                        Writer.WriteInfo.combolist.Add(line);
                    }

                    Writer.WriteInfo.combolist = Writer.WriteInfo.combolist.Distinct().ToList();
                    Console.Title = String.Format("ZLX-Editor | Loaded {0} Lines - Removed {1} duplicates!", new object[]
                    {
                        Writer.WriteInfo.combolist.Count<string>(),
                        combocount - Writer.WriteInfo.combolist.Count<string>()
                    });
                }
            }
        }

    }
}
