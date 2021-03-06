﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bandit_Odnorukiy_Zlodey_Pr10S2_
{
  public partial class Казино : Form
  {
        int balance = 100;
        int counter_money = 0;
        int counter_try = 0;
        int win_money = 0;
        bool IsActive = true;

    public Казино()
    {
      InitializeComponent();
    }

        private void button2_Click(object sender, EventArgs e)
        {
            Init_Counter(numericUpDown1.Value);
            ПОГНАЛИ.Enabled = true;
            button2.Enabled = false;
        }

        private void dvg1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int dvg = rnd.Next(8);
            label1.Text = dvg.ToString();
        }

        private void dvg2_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int dvg = rnd.Next(8);
            label2.Text = dvg.ToString();
        }

        private void dvg3_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int dvg = rnd.Next(8);
            label3.Text = dvg.ToString();
        }

        private void stop1_Tick(object sender, EventArgs e)
        {
            dvg1.Enabled = false;
            stop1.Enabled = false;
        }

        private void stop2_Tick(object sender, EventArgs e)
        {
            dvg2.Enabled = false;
            stop2.Enabled = false;
        }

        private void stop3_Tick(object sender, EventArgs e)
        {
            counter_try--;
            dvg3.Enabled = false;
            stop3.Enabled = false;
            Win_Money();
            if(IsActive)
            {
                if (counter_try != 0)
                {
                    label6.Text = "Осталось попыток: " + counter_try;
                    ПОГНАЛИ.Enabled = true;
                }
                else
                {
                    label6.Text = "Осталось попыток: " + counter_try;
                    MessageBox.Show("Делайте новую ставку!", "Попытки закончились :с", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    button2.Enabled = true;
                }
            }
        }

        private void Win_Money()
        {
            if (label1.Text == "0" && label2.Text == "0" && label3.Text == "0") Upd_Win(17);
            if (label1.Text == "1" && label2.Text == "1" && label3.Text == "1") Upd_Win(10);
            if (label1.Text == "2" && label2.Text == "2" && label3.Text == "2") Upd_Win(11);
            if (label1.Text == "3" && label2.Text == "3" && label3.Text == "3") Upd_Win(12);
            if (label1.Text == "4" && label2.Text == "4" && label3.Text == "4") Upd_Win(13);
            if (label1.Text == "4" && label2.Text == "5" && label3.Text == "5") Upd_Win(14);
            if (label1.Text == "6" && label2.Text == "6" && label3.Text == "6") Upd_Win(15);
            if (label1.Text == "7" && label2.Text == "7" && label3.Text == "7") Upd_Win(20);

            if ((label1.Text == "0" && label2.Text == "0") || (label1.Text == "0" && label3.Text == "0") || (label2.Text == "0" && label3.Text == "0")) Upd_Win(10);
            if ((label1.Text == "1" && label2.Text == "1") || (label1.Text == "1" && label3.Text == "1") || (label2.Text == "1" && label3.Text == "1")) Upd_Win(1);
            if ((label1.Text == "2" && label2.Text == "2") || (label1.Text == "2" && label3.Text == "2") || (label2.Text == "2" && label3.Text == "2")) Upd_Win(2);
            if ((label1.Text == "3" && label2.Text == "3") || (label1.Text == "3" && label3.Text == "3") || (label2.Text == "3" && label3.Text == "3")) Upd_Win(3);
            if ((label1.Text == "4" && label2.Text == "4") || (label1.Text == "4" && label3.Text == "4") || (label2.Text == "4" && label3.Text == "4")) Upd_Win(4);
            if ((label1.Text == "5" && label2.Text == "5") || (label1.Text == "5" && label3.Text == "5") || (label2.Text == "5" && label3.Text == "5")) Upd_Win(5);
            if ((label1.Text == "6" && label2.Text == "6") || (label1.Text == "6" && label3.Text == "6") || (label2.Text == "6" && label3.Text == "6")) Upd_Win(6);
            if ((label1.Text == "7" && label2.Text == "7") || (label1.Text == "7" && label3.Text == "7") || (label2.Text == "7" && label3.Text == "7")) Upd_Win(7);
        }

        private void Upd_Win(int number)
        {
            win_money = counter_money * number;
            DialogResult result = MessageBox.Show("Браво, вы сорвали куш в размере $" + win_money, "Поздравляем", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            balance = balance + win_money;
            label4.Text = "Баланс: $" + balance;
            ПОГНАЛИ.Enabled = false;
            button2.Enabled = true;
            IsActive = false;
            if (result == DialogResult.OK)
            {
                MessageBox.Show("Делайте новую ставку!", "Новая игра", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                label6.Text = "Осталось попыток: 0";
            }
        }

        private void Init_Counter(decimal counter)
        {
            counter_money = Convert.ToInt32(counter);
            balance = balance - counter_money;
            label4.Text = "Баланс: $" + balance;
            counter_try = 5;
            label6.Text = "Осталось попыток: " + counter_try;
        }

        private void ПОГНАЛИ_Click(object sender, EventArgs e)
        {
            dvg1.Enabled = true;
            dvg2.Enabled = true;
            dvg3.Enabled = true;
            stop1.Enabled = true;
            stop2.Enabled = true;
            stop3.Enabled = true;
            IsActive = true;
            ПОГНАЛИ.Enabled = false;
        }
    }
}
