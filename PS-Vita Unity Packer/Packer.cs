using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ionic.Zip;
using System.IO;

namespace PS_Vita_Unity_Packer
{
    /*
-print("-i Input Path")
-print("-o Output Path")
+print("-f Fix Unsafe Homebrew Bug")
+print("-u Remove \"Trial Version\" Watermark")
+print("-r Remove unused files")
print("-p Pack to VPK")
print("-d Remove input folder after packing to vpk.")
print("-bt Add build time to output folder")
print("\nExample: UnityTools -i input -o output -f -u -r -p -d -bt")
    */
    internal class Packer
    {
        public Action<string> outLog;
        string inputFolder = "psVita";
        string outFile = "psVita";
        readonly static string watermark = "UnityWatermark-trial";
        static string selfFile = "";
        public bool init = false;
        public bool Init(string inputFolder, string outFile)
        {
            this.inputFolder = inputFolder;
            this.outFile = outFile;
            string supportedExtensions = "*.self,eboot.bin";
            foreach(string imageFile in Directory.GetFiles(this.inputFolder, "*.*", SearchOption.AllDirectories).Where(s => supportedExtensions.Contains(Path.GetExtension(s).ToLower())))
            {
                selfFile = imageFile;
                init = true;
                return init;
                //do work here
            }
            init = false;
            return init;
        }
        public void UnsafeFix()
        {
            if(!init)
                return;
            outLog("Fixing Unsafe Homebrew bug. . .");
            FileStream file = new FileStream(selfFile, FileMode.Open);
            file.Seek(0x80, SeekOrigin.Begin);
            file.WriteByte(0);
            file.Flush(true);
            file.Close();
            outLog("Fixed!");
        }
        public void RemoveWaterMark()
        {
            if(!init)
                return;
            outLog("Removing \"Trial Version\" Watermark. . .");
            FileStream file = new FileStream(inputFolder + "\\Media\\Resources\\unity default resources", FileMode.Open);
            file.Seek(0, SeekOrigin.Begin);
            int b = 0, c = 0;

            outLog("Processing . . .\r");
			while (true && file.Position < file.Length)
			{
				b = file.ReadByte();
				if (c >= watermark.Length)
				{
					if (b != 45)
						break;
					else
						c = 0;
				}
				if (b == watermark[c])
				{
					c++;
				}
				else
				{
					c = 0;
				}
			}
			c = 112;
			while (c > 0 && file.Position < file.Length)
			{
				file.WriteByte(0);
				c--;
			}
            /*while(true && file.Position < file.Length)
            {
                b = file.ReadByte();
                if(b == watermark[c])
                {
                    c++;
                    if(c == watermark.Length)
                    {
                        break;
                    }
                }
                else
                {
                    c = 0;
                }
            }
            c = 112;
            while(c > 0 && file.Position < file.Length)
            {
                file.WriteByte(0);
                c--;
            }*/
            file.Flush(true);
            file.Close();
            outLog("Watermark Removed.");
        }
        public void RemoveUnusedFiles()
        {
            if(!init)
                return;
            outLog("Removing unused files. . .");
            if(Directory.Exists(inputFolder + "\\SymbolFiles"))
                Directory.Delete(inputFolder + "\\SymbolFiles", true);
            if(File.Exists(inputFolder + "\\configuration.psp2path"))
                File.Delete(inputFolder + "\\configuration.psp2path");
            if(File.Exists(inputFolder + "\\ScriptLayoutHashes.txt"))
                File.Delete(inputFolder + "\\ScriptLayoutHashes.txt");
            foreach(var item in Directory.GetFiles(inputFolder, "*.bat", SearchOption.AllDirectories))
            {
                File.Delete(item);
            }
            outLog("Removed unused files . . .");
        }

        public void PackToVPK() {
            PackToVPK(outFile);
        }
        public void PackToVPK(string outFile)
        {
            if(!init)
                return;
            outFile = outFile + ".vpk";
            outLog("Begin package VPK:"+ outFile);
            if(!selfFile.EndsWith("eboot.bin") && !File.Exists(inputFolder + "\\eboot.bin"))
                File.Move(selfFile, inputFolder + "\\eboot.bin");
            if(File.Exists(outFile))
                File.Delete(outFile);
            string[] files = Directory.GetFiles(inputFolder, "*", SearchOption.AllDirectories);

            ZipFile zipFile = new ZipFile(outFile, Encoding.Default);
            string str = "";
            foreach(var item in files)
            {
                str = item.Remove(0, inputFolder.Length);
                outLog("Add in VPK:"+str);
                str = str.Remove(str.Length - Path.GetFileName(str).Length);
                ZipEntry entry = zipFile.AddItem(item, str);
                entry.CompressionMethod = CompressionMethod.Deflate;
                entry.Attributes = ((FileAttributes)0);
            }
            zipFile.Save();
            outLog("VPK complete!");
        }
        public void RemoveInputFolder()
        {
            outLog("Delete input Folder");
            if(!init)
                return;
            Directory.Delete(inputFolder, true);
            outLog("Complete!");
        }
    }
}
