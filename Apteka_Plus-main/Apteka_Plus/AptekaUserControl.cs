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
    public partial class AptekaUserControl : UserControl
    {
        public AptekaUserControl(string id)
        {
            InitializeComponent();

            NumberLabel.Text = id;

            pictureBox1.Load("../../Pictures/Аптека" + id + ".jpg");
        }

      

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            MedicomentUserControl medicomentUC = new MedicomentUserControl(lb.Tag.ToString());
            Controls.Clear();
            Controls.Add(medicomentUC);
            medicomentUC.Dock = DockStyle.None;

        }

        private void AptekaUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
