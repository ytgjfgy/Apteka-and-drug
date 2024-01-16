namespace Apteka_Plus
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Психотропные медикаменты");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Препараты местноанастезирающего действия ");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Моче Желчегонные  медикаменты");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Антибиотики");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("средства для терапии секреторики  ");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Аптека №1", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Психотропные медикаменты");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Препараты местноанастезирающего действия ");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Моче Желчегонные  медикаменты");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Антибиотики");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("средства для терапии секреторики  ");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Аптека №2", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Аптеки", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode12});
            this.AuthPanel = new System.Windows.Forms.Panel();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.CopyRightPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AuthPanel
            // 
            this.AuthPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AuthPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AuthPanel.Location = new System.Drawing.Point(0, 0);
            this.AuthPanel.Name = "AuthPanel";
            this.AuthPanel.Size = new System.Drawing.Size(1103, 61);
            this.AuthPanel.TabIndex = 0;
            // 
            // InfoPanel
            // 
            this.InfoPanel.BackColor = System.Drawing.Color.White;
            this.InfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoPanel.Location = new System.Drawing.Point(341, 3);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(759, 506);
            this.InfoPanel.TabIndex = 1;
            this.InfoPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.InfoPanel_Paint);
            // 
            // CopyRightPanel
            // 
            this.CopyRightPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CopyRightPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CopyRightPanel.Location = new System.Drawing.Point(0, 573);
            this.CopyRightPanel.Name = "CopyRightPanel";
            this.CopyRightPanel.Size = new System.Drawing.Size(1103, 40);
            this.CopyRightPanel.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.6437F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.3563F));
            this.tableLayoutPanel1.Controls.Add(this.InfoPanel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.treeView1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 61);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1103, 512);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Узел3";
            treeNode1.Tag = "1";
            treeNode1.Text = "Психотропные медикаменты";
            treeNode2.Name = "Узел5";
            treeNode2.Tag = "2";
            treeNode2.Text = "Препараты местноанастезирающего действия ";
            treeNode3.Name = "Узел6";
            treeNode3.Tag = "3";
            treeNode3.Text = "Моче Желчегонные  медикаменты";
            treeNode4.Name = "Узел7";
            treeNode4.Tag = "4";
            treeNode4.Text = "Антибиотики";
            treeNode5.Name = "Узел8";
            treeNode5.Tag = "5";
            treeNode5.Text = "средства для терапии секреторики  ";
            treeNode6.Name = "Узел1";
            treeNode6.Tag = "1";
            treeNode6.Text = "Аптека №1";
            treeNode7.Name = "Узел4";
            treeNode7.Tag = "1";
            treeNode7.Text = "Психотропные медикаменты";
            treeNode8.Name = "Узел9";
            treeNode8.Tag = "2";
            treeNode8.Text = "Препараты местноанастезирающего действия ";
            treeNode9.Name = "Узел10";
            treeNode9.Tag = "3";
            treeNode9.Text = "Моче Желчегонные  медикаменты";
            treeNode10.Name = "Узел11";
            treeNode10.Tag = "4";
            treeNode10.Text = "Антибиотики";
            treeNode11.Name = "Узел12";
            treeNode11.Tag = "5";
            treeNode11.Text = "средства для терапии секреторики  ";
            treeNode12.Name = "Узел2";
            treeNode12.Tag = "2";
            treeNode12.Text = "Аптека №2";
            treeNode13.Name = "Узел0";
            treeNode13.Text = "Аптеки";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode13});
            this.treeView1.Size = new System.Drawing.Size(332, 506);
            this.treeView1.TabIndex = 2;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 613);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.CopyRightPanel);
            this.Controls.Add(this.AuthPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AuthPanel;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.Panel CopyRightPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TreeView treeView1;
    }
}

