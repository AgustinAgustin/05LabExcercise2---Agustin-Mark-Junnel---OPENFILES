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

namespace _05LabExcercise2
{
    public partial class FrmStudentRecords : Form
    {
        public FrmStudentRecords()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FrmRegistration registration = new FrmRegistration();
            registration.ShowDialog();
        }
        public String path;
        private void btnFindFiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();

            file.InitialDirectory = @"C:\";
            file.Title = "Browse Text Files";
            file.DefaultExt = "txt";
            file.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (file.ShowDialog() == DialogResult.OK)
            {
                path = file.FileName;
                using (StreamReader streamReader = File.OpenText(path))
                {
                    string _getText = "";
                    while ((_getText = streamReader.ReadLine()) != null)
                    {
                        Console.WriteLine(_getText);
                        ListViewShowText.Items.Add(_getText);
                    }
                }
            }
        }

        private void btnUploadFiles_Click(object sender, EventArgs e)
        {
            ListViewShowText.Items.Clear();
            MessageBox.Show("UPLOADED!");
        }
    }
}
