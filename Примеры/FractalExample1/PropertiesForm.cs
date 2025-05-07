﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class PropertiesForm : Form
    {
        public Properties Properties { get; set; } = new();

        public PropertiesForm()
        {
            InitializeComponent();

            propertyGrid.SelectedObject = Properties;
        }
    }
}
