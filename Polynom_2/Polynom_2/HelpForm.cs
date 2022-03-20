using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        private void HelpForm_Load(object sender, EventArgs e)
        {
            txtBoxfaculty.SelectionStart = txtBoxfaculty.Text.Length;
            txtBoxCurseWork.SelectionStart = txtBoxCurseWork.Text.Length;
            txtBoxPolynom.SelectionStart = txtBoxPolynom.Text.Length;
            txtBoxMyName.SelectionStart = txtBoxMyName.Text.Length;
            txtBoxTeacherName.SelectionStart = txtBoxTeacherName.Text.Length;
            txtBoxCity.SelectionStart = txtBoxCity.Text.Length;
            
            //Відмінити автовибір для текстових полів//
            txtBoxfaculty.DeselectAll();
            txtBoxCurseWork.DeselectAll();
            txtBoxPolynom.DeselectAll();
            txtBoxMyName.DeselectAll();
            txtBoxTeacherName.DeselectAll();
            txtBoxCity.DeselectAll();
        }       
    }
}
