﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Year_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CurrData.LoadLocalDatabase();
            listBox1.DataSource = CurrData.clientData;
            listBox1.DisplayMember = "displayName";
        }
    }
}
