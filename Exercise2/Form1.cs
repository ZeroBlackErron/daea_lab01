using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string code = "U" + usersTable.RowCount.ToString();

            usersTable.Rows.Add(
                code, 
                txtName.Text, 
                txtLastName.Text, 
                txtAddress.Text, 
                txtEmail.Text, 
                txtPhone.Text, 
                dpBirthdate.Text,
                cboDepartment.Text
            );

            int c = usersTable.RowCount;
            idLabel.Text = "U" + c;
        }

        private void Form1_Enter(object sender, EventArgs e)
        {
            //
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            idLabel.Text = "U" + usersTable.RowCount;
        }
    }
}
