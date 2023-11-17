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
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            String path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            String[] data =
            {
                $"Student Number: {txtStudentNumber.Text}",$"Full Name: {txtLastname.Text}, {txtFirstName.Text} {txtMiddleName.Text}", $"Program: {cbPrograms.Text}",$"Gender: {cbGender.Text}",
                $"Age: {txtAge.Text}", $"Birthday: {datetimeBirthday.Value}", $"Contact Number: {txtContactNumber.Text}"
            };
            using (StreamWriter write = new StreamWriter($"{path}\\{txtStudentNumber.Text}.txt"))
            {
                foreach (var item in data)
                {
                    write.WriteLine(item);
                }
            }
            MessageBox.Show("Registered!");
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            FrmStudentRecords rec = new FrmStudentRecords();
            rec.ShowDialog();
        }
    }
}
