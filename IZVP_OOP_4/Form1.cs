using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IZVP_OOP_4.Models;

namespace IZVP_OOP_4
{
    public partial class Form1 : Form
    {
        List<Auto> autos = new List<Auto>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            string firstName = textBox_FirstName.Text;
            string lastName = textBox_LastName.Text;
            string autoCode = textBox_AutoCode.Text;
            string model = textBox_Model.Text;
            string color = textBox_Color.Text;
            autos.Add(new Auto(
                firstName,
                lastName,
                autoCode,
                model,
                color
            ));
            listBox_Names.Items.Add(autoCode);
            textBox_FirstName.Clear();
            textBox_LastName.Clear();
            textBox_AutoCode.Clear();
            textBox_Model.Clear();
            textBox_Color.Clear();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBox_Names.SelectedIndex;
            autos.RemoveAt(selectedIndex);
            listBox_Names.Items.RemoveAt(selectedIndex);
        }
    }
}