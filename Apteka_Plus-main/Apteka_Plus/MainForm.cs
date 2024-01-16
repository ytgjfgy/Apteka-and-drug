using System;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            Text = "Аптека Плюс";

            MainUserControl mainUC = new MainUserControl();
            mainUC.Dock = DockStyle.Fill;
            InfoPanel.Controls.Clear();
            InfoPanel.Controls.Add(mainUC); 

        }

        private void InfoPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(e.Node.Level == 0 && e.Node.Text == "Аптеки")
            {
                MainUserControl mainUC = new MainUserControl();
                mainUC.Dock = DockStyle.Fill;
                InfoPanel.Controls.Clear();
                InfoPanel.Controls.Add(mainUC);

            }

            else if(e.Node.Level == 1 && e.Node.Parent.Text == "Аптеки")
            {
              AptekaUserControl aptekaUC = new AptekaUserControl(e.Node.Tag.ToString());
                aptekaUC.Dock = DockStyle.Fill;
                InfoPanel.Controls.Clear();
                InfoPanel.Controls.Add(aptekaUC);
            }

            else if (e.Node.Level == 2 && e.Node.Parent.Parent.Text == "Аптеки")
            {
                MedicomentUserControl medicomentUC = new MedicomentUserControl(e.Node.Tag.ToString());
                medicomentUC.Dock = DockStyle.Fill;
                InfoPanel.Controls.Clear();
                InfoPanel.Controls.Add(medicomentUC);
            }
        }
    }
}
