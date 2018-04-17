using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeShop
{
    static class Program
    {
      public static  string loc = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\CafeShop\CafeShop\Database1.mdf;Integrated Security=True";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new login());
        }
    }
}
