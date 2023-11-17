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

namespace Reading_a_File
{
    public partial class FrmStudentRecord : Form
    {
        public FrmStudentRecord()
        {
            InitializeComponent();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            FrmRegistration fr = new FrmRegistration();
            fr.ShowDialog();
        }

        private void Upload_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully Uploaded!");
            lvView.Items.Clear();
        }

        private void Find_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            String path;
            file.InitialDirectory = @"C:\";
            file.Title = "Browse Text Files";
            file.DefaultExt = "txt";
            file.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            file.ShowDialog();
            path = file.FileName;
            using (StreamReader streamReader = File.OpenText(path))
            {
                string _getText = "";
                while ((_getText = streamReader.ReadLine()) != null)
                {
                    Console.WriteLine(_getText);
                    lvView.Items.Add(_getText);
                }
            }
        }
    }
}
