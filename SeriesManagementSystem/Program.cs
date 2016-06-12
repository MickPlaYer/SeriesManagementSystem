using SeriesManagementSystem.Domain;
using SeriesManagementSystem.Foundation;
using SeriesManagementSystem.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeriesManagementSystem
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Software software = new Software(new ServerHelper(), new FileManager());
            Application.Run(new SoftwareForm(software));
        }
    }
}
