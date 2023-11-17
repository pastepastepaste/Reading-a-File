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
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            String[] input = {$"Student Number : { txtStudent.Text}", $"Full Name : {txtLastName.Text}",
                              $"Program : {Program.Text}", $"Gender : {Gender.Text}", $"Age : {txtAge.Text}",
                              $"Birthday : {BirthDay.Text}" , $"Contact Number : {txtContactNum.Text}"};
            using (StreamWriter sw = new StreamWriter($"{path}\\{txtStudent.Text}.txt"))
            {
                foreach (var item in input) { sw.WriteLine(item); }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmStudentRecord studentRecord = new FrmStudentRecord();
            studentRecord.ShowDialog();
        }
    }
}
