using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Batch_WAV_to_OGG_Converter
{
    public partial class frmMain : Form
    {
        List<string> filenames;
        string filepath = "";
        int currentFile;
        Process process;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnChooseSource_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            grpBegin.Hide();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtSource.Text = fbd.SelectedPath;
                filenames = new List<string>();
                filenames.AddRange(Directory.GetFiles(fbd.SelectedPath, "*.wav"));
                filepath = fbd.SelectedPath;
                filenames.Sort();
                if (filenames.Count > 0)
                {
                    grpBegin.Show();
                }
                else
                {
                    MessageBox.Show("No wav files found.");
                }
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            currentFile = 0;
            Directory.CreateDirectory(filepath + "/Old Wavs");
            btnChooseSource.Enabled = false;
            btnConvert.Hide();
            convertProgress.Show();
            ConvertFile();
        }

        void ConvertFile()
        {
            process = new Process();
            process.StartInfo.FileName = Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName) +
                                    @"\ffmpeg\ffmpeg.exe";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.Arguments = "-i " + '"' + filenames[currentFile] + '"' + " -acodec libvorbis -f ogg " + '"' + filenames[currentFile].Substring(0, filenames[currentFile].Length - 4) + ".ogg" + '"';
            process.Start();

            while (process.HasExited == false)
            {
                System.Threading.Thread.Sleep(10);
                Application.DoEvents();
            }

            File.Move(filenames[currentFile], filepath + "/Old Wavs/" + filenames[currentFile].Replace(filepath, ""));
            currentFile++;
            convertProgress.Value = (int)((double)((double)currentFile / (double)filenames.Count) * 100.0);
            if (currentFile < filenames.Count) { 
                ConvertFile(); 
            }
            else
            {
                MessageBox.Show("Wavs converted successfully. Batch wav to ogg converter courtesy of Ascension Game Dev. http://www.ascensiongamedev.com \nHave a great day!");
                Application.Exit();
            }
        }
    }
}
