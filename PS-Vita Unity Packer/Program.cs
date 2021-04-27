using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PS_Vita_Unity_Packer
{
    class Program
    {
        [DllImport("kernel32.dll",
   EntryPoint = "AllocConsole",
   SetLastError = true,
   CharSet = CharSet.Auto,
   CallingConvention = CallingConvention.StdCall)]
        private static extern int AllocConsole();

        [STAThread]
        static void Main(string[] args)
        {
            if(args.Length > 0)
            {
                Packer pack = new Packer();
                AllocConsole();
                pack.outLog += Console.WriteLine;
                Console.WriteLine(Form_Packer.version);
                foreach(var item in args)
                {
                    if(pack.Init(item, item))
                    {
                        pack.UnsafeFix();
                        pack.RemoveUnusedFiles();
                        pack.RemoveWaterMark();
                        pack.PackToVPK();
                        pack.RemoveInputFolder();
                    }
                }
                return;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_Packer());
        }
    }
}
