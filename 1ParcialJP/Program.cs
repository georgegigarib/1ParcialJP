using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1ParcialJP
{
    static class Program
    {
        public static string _tipo;
        public static string tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMarca());
        }
    }
}
