﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KołkoKrzyzyk
{
    public partial class Form1 : Form
    {
        char who = 'x';
        short movement = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void nowaGraToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void infoToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            bt.Enabled = false;
            bt.BackColor = Color.YellowGreen;
            if (who == 'x')
            {
                bt.Text = "x";
                if((b1.Text == b2.Text && b2.Text == b3.Text && b2.Text != "") ||
                   (b4.Text == b5.Text && b5.Text == b6.Text && b5.Text != "") ||
                   (b7.Text == b8.Text && b8.Text == b9.Text && b8.Text != "") ||
                   (b1.Text == b4.Text && b4.Text == b7.Text && b4.Text != "") ||
                   (b2.Text == b5.Text && b5.Text == b8.Text && b5.Text != "") ||
                   (b3.Text == b6.Text && b6.Text == b9.Text && b6.Text != "") ||
                   (b1.Text == b5.Text && b5.Text == b9.Text && b5.Text != "") ||
                   (b3.Text == b5.Text && b5.Text == b7.Text && b5.Text != ""))
                {
                    MessageBox.Show(($"Wygrywa {who.ToString().ToUpper() } !!!"));
                    tableLayoutPanel1.Enabled = false;
                }
                else if (movement == 8)
                {
                    MessageBox.Show("Remis!");
                }
                who = 'o';

            }
            else if(who == 'o')
            {
                bt.Text = "o";
                if ((b1.Text == b2.Text && b2.Text == b3.Text && b2.Text != "") ||
                   (b4.Text == b5.Text && b5.Text == b6.Text && b5.Text != "") ||
                   (b7.Text == b8.Text && b8.Text == b9.Text && b8.Text != "") ||
                   (b1.Text == b4.Text && b4.Text == b7.Text && b4.Text != "") ||
                   (b2.Text == b5.Text && b5.Text == b8.Text && b5.Text != "") ||
                   (b3.Text == b6.Text && b6.Text == b9.Text && b6.Text != "") ||
                   (b1.Text == b5.Text && b5.Text == b9.Text && b5.Text != "") ||
                   (b3.Text == b5.Text && b5.Text == b7.Text && b5.Text != ""))
                {
                    MessageBox.Show(($"Wygrywa {who.ToString().ToUpper() } !!!"));
                    tableLayoutPanel1.Enabled = false;
                }
                else if (movement == 8)
                {
                    MessageBox.Show("Remis!");
                }
                who = 'x';
            }
            movement++;

        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            who = 'x';
            movement = 0;
            b1.Enabled = true; b1.Text = ""; b1.BackColor = Color.White;
            b2.Enabled = true; b2.Text = ""; b2.BackColor = Color.White;
            b3.Enabled = true; b3.Text = ""; b3.BackColor = Color.White;
            b4.Enabled = true; b4.Text = ""; b4.BackColor = Color.White;
            b5.Enabled = true; b5.Text = ""; b5.BackColor = Color.White;
            b6.Enabled = true; b6.Text = ""; b6.BackColor = Color.White;
            b7.Enabled = true; b7.Text = ""; b7.BackColor = Color.White;
            b8.Enabled = true; b8.Text = ""; b8.BackColor = Color.White;
            b9.Enabled = true; b9.Text = ""; b9.BackColor = Color.White;
            tableLayoutPanel1.Enabled = true;

        }
    }
}
