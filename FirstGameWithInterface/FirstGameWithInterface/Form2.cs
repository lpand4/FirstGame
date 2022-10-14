using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FirstGameWithInterface
{
    public partial class Form2 : Form
    {

      
        public Form2()
        {
            InitializeComponent();
        }

// Должно разрешать вводить в текстовое окно только цифры
  //      private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
  //      {
  //          if (!Char.IsDigit(e.KeyChar))
  //              e.Handled = true;
  //      }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void CheckBox1_TextChanged(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(CheckBox1.Text);
        }
    }
}
