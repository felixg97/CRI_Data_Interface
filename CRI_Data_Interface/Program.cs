using System;
using System.Windows.Forms;

namespace CRI_Data_Interface
{
    public class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CRIDataInterfaceGUI());
            Application.Exit();
        }

    }
}
