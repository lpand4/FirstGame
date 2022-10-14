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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;



 
namespace FirstGameWithInterface
{
    
    public partial class Form2 : Form
    {

      
        public Form2()
        {
            InitializeComponent();            
        }

// Должно разрешать вводить в текстовое окно только цифры
        private void CheckBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Вводите число, а не текст");
            }
        }

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
       //CheckBtn  должна проверять текст написанный в CheckBox1 и в соответствии с игрой выполняла действия.
        private void CheckBtn_Click(object sender, EventArgs e)
        {
          
            if (Convert.ToInt32(CheckBox1.Text) == 1)
                MessageBox.Show("Молодец!");
            else
                MessageBox.Show("Попробуй еще раз");
        }
    }
}
