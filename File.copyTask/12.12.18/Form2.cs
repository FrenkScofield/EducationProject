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

namespace _12._12._18
{
    public partial class Form2 : Form
    {
        List<string> imgs = new List<string>();
        static string source;
        public Form2()
        {
            InitializeComponent();

        }

        private void Choosebtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg|PNG files(*.png) |*.png|All Files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Photobox.Image = Image.FromFile(dialog.FileName);
                    source = dialog.FileName;
                    
                    imgs.Add(dialog.FileName);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Savedbbtn_Click(object sender, EventArgs e)
        {
            string folderPath = "";
            
            FolderBrowserDialog directchoosedlg = new FolderBrowserDialog();
            if (directchoosedlg.ShowDialog() == DialogResult.OK)
            {
                folderPath = directchoosedlg.SelectedPath;
                
            }

            File.Copy(source, Path.Combine(folderPath, Path.GetFileName(source)), true);


        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
