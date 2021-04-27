using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PS_Vita_Unity_Packer
{
    public partial class Form_Packer : Form
    {
        public static string version="psVita Packer 0.3";

        Packer pack;

        Encoding ascii = Encoding.GetEncoding(1251);
        Encoding unicode = Encoding.GetEncoding(866);

        public Form_Packer()
        {
            InitializeComponent();
            Name = "GUI "+version;
            pack = new Packer();
            pack.outLog = DoLog;
        }

        public void DoLog(string txt)
        {
            if(string.IsNullOrEmpty(txt))
                return;
            byte[] bytes = ascii.GetBytes(txt);
            string asciiString = unicode.GetString(bytes);
            LogBox.Text += asciiString + Environment.NewLine;
            LogBox.SelectionStart = LogBox.Text.Length;
            LogBox.ScrollToCaret();
        }

        private void Btn_Select_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                string file = Path.GetDirectoryName(openFileDialog1.FileName);
                if(pack.Init(file, file))
                {
                    DoLog("Select Path:"+ file);
                    BTN_Pack.Enabled = pack.init;
                    InputBox.Text = file;
                }
            }
        }
        bool bDeleteInput,bFix,bDeleteUnused,bRemoteWatermark;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bDeleteInput = checkBox1.Checked;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            bFix = checkBox3.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            bDeleteUnused = checkBox2.Checked;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            bRemoteWatermark = checkBox4.Checked;
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            new Message().ShowDialog(this);
        }

        private void BTN_Pack_Click(object sender, EventArgs e)
        {
            LogBox.Text = "";
            BTN_Pack.Enabled = false;
            progressBar.Value = 0;
            if (bFix)
                pack.UnsafeFix();
            progressBar.Value = 15;
            if (bDeleteUnused)
                pack.RemoveUnusedFiles();
            progressBar.Value = 33;
            if (bRemoteWatermark)
                pack.RemoveWaterMark();
            progressBar.Value = 50;
            pack.PackToVPK();
            progressBar.Value = 75;
            if (bDeleteInput)
                pack.RemoveInputFolder();
            progressBar.Value = 100;
        }

        private void InputBox_DragDrop(object sender, DragEventArgs e)
        {
            object text = e.Data.GetData(DataFormats.FileDrop);
            if(InputBox != null)
            {
                InputBox.Text = Path.GetPathRoot(string.Format("{0}", ((string[])text)[0]));
            }
        }

        private void Form_Packer_DragDrop(object sender, DragEventArgs e)
        {
            InputBox_DragDrop(sender, e);
        }
    }
}
