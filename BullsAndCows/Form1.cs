using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BullsAndCows
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        string[] digits;
        string number;
        string tmp;
        int N;

        public void setNewNumber()
        {
            number = null;
            N = int.Parse(N_textbox.Text);
            digits = new string[N];
            digits[0] = rnd.Next(1, 10).ToString();
            for (int i = 1; i < N; i++)
            {
                digits[i] = rnd.Next(0, 10).ToString();
                for (int j = 0; j < i; j++)
                {
                    if (digits[j] == digits[i])
                        i--;
                }
            }
            for (int i = 0; i < N; i++)
            {
                number += digits[i];
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Compare_button_Click(object sender, EventArgs e)
        {
            int cows = 0;
            int bulls = 0;
            tmp = inputTextbox.Text;
            for (int i = 0; i < N; i++)
            {
                if (tmp[i] == number[i])
                    bulls++;
                for (int j = 0; j < N; j++)
                {
                    if (tmp[i] == number[j])
                        cows++;
                }
            }
            if (cows > 0)
                cows -= bulls;
            logTextbox.Text += tmp + " - быков: " + bulls + ", коров: " + cows + Environment.NewLine;
            if (bulls == N)
                logTextbox.Text += "Вы отгадали загаданное число";
        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            logTextbox.Text = null;
            inputTextbox.Text = null;
            setNewNumber();
            status_label.Text = null;
        }

        private void genNewNumber_Click(object sender, EventArgs e)
        {
            setNewNumber();
            status_label.Text = "Число загадано";
        }
    }
}
