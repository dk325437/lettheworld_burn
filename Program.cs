using System;
using System.Windows.Forms;

namespace lettheworld_burn
{
    internal static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1()); // hoặc Form3 nếu bạn muốn
        }
    }
}
