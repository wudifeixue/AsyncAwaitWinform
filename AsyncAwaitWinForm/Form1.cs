﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace AsyncAwaitWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }        

        private int CountCharacters()
        {
            int count = 0;
            using(StreamReader reader = new StreamReader("c:\\Data\\Data.txt"))
            {
                string content = reader.ReadToEnd();
                count = content.Length;
                Thread.Sleep(5000);
            }

            return count;

        }

        private void btnProcessFile_Click(object sender, EventArgs e)
        {
            lblCount.Text = "Processing File. Please wait...";
            int count = CountCharacters();
            lblCount.Text = count.ToString() + " charaters in file";
        }
    }
}
