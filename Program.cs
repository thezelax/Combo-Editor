using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZLX_Combo_Editor
{
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Loader.Menu.Interface(); Loader.Menu.List();
            Loader.CreateDir();
            Loader.LoadCombo();
            Loader.KeyReader();
            Console.ReadKey();
        }
    }
}
