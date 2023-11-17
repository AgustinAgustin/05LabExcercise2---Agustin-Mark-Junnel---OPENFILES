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
    public partial class FrmOpenTextFile : Form
    {
        public FrmOpenTextFile()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            DisplayToList();
        }
        void DisplayToList() {
            String path;
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Browse Text Files";
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.ShowDialog();
            path = openFileDialog1.FileName;
            using (StreamReader streamReader = File.OpenText(path))
            {
                string getText = "";
                while ((getText = streamReader.ReadLine()) != null)
                {
                    Console.WriteLine(getText);
                    lvShowText.Items.Add(getText);
                }
            }
        }

        private void btnGoStudentRecords_Click(object sender, EventArgs e)
        {
            FrmStudentRecords student = new FrmStudentRecords();
            student.ShowDialog();
        }
    }
}
