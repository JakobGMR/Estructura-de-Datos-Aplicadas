using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2P___A4_Prácticas_Pilas_y_Colas
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string num1 = Number1TextBox.Text;
            string num2 = Number2TextBox.Text;

            string result = SumLargeNumbers(num1, num2);
            ResultLabel.Text = result;

            listBoxNumber1.Items.Clear();
            listBoxNumber2.Items.Clear();
            listBoxResult.Items.Clear();

            foreach (char c in num1)
            {
                listBoxNumber1.Items.Insert(0, c);
            }

            foreach (char c in num2)
            {
                listBoxNumber2.Items.Insert(0, c);
            }

            foreach (char c in result)
            {
                listBoxResult.Items.Insert(0, c);
            }
        }

        private string SumLargeNumbers(string num1, string num2)
        {
            Stack<int> stack1 = new Stack<int>();
            Stack<int> stack2 = new Stack<int>();
            Stack<int> resultStack = new Stack<int>();
            int carry = 0;

            foreach (char c in num1)
            {
                stack1.Push(int.Parse(c.ToString()));
            }

            foreach (char c in num2)
            {
                stack2.Push(int.Parse(c.ToString()));
            }

            while (stack1.Count > 0 || stack2.Count > 0 || carry > 0)
            {
                int digit1 = (stack1.Count > 0) ? stack1.Pop() : 0;
                int digit2 = (stack2.Count > 0) ? stack2.Pop() : 0;
                int sum = digit1 + digit2 + carry;
                carry = sum / 10;
                resultStack.Push(sum % 10);
            }

            string result = string.Join("", resultStack);

            return result;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inicio form1 = new Inicio();
            form1.Show();
            this.Close();
        }

        private void Number1TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
