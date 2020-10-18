﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelaDeLinks
{
    public partial class formLink : Form
    {
        public formLink()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirLink("https://github.com/Kaecio");
        }

        private void AbrirLink(string endLink)
        {
            System.Diagnostics.Process.Start(endLink);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirLink("https://app.betrybe.com/course");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirLink("https://www.freecodecamp.org/learn/");
        }
    }
}
