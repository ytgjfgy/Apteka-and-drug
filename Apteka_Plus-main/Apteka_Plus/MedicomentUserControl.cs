﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apteka_Plus
{
    public partial class MedicomentUserControl : UserControl
    {
        public MedicomentUserControl(string id)
        {
            InitializeComponent();

            pictureBox1.Load("../../Pictures/" + id + ".jpg");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
