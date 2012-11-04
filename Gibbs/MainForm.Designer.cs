namespace Gibbs
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.chart = new System.Windows.Forms.PictureBox();
            this.data = new System.Windows.Forms.DataGridView();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.daneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszDaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszWykresJakoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ustawieniaWykresuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SplitLayout = new System.Windows.Forms.SplitContainer();
            this.przyciski = new System.Windows.Forms.ToolStrip();
            this.DrawDataBtn = new System.Windows.Forms.ToolStripButton();
            this.StripsContainer = new System.Windows.Forms.ToolStripContainer();
            this.status = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            this.AColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.menu.SuspendLayout();
            this.SplitLayout.Panel1.SuspendLayout();
            this.SplitLayout.Panel2.SuspendLayout();
            this.SplitLayout.SuspendLayout();
            this.przyciski.SuspendLayout();
            this.StripsContainer.BottomToolStripPanel.SuspendLayout();
            this.StripsContainer.ContentPanel.SuspendLayout();
            this.StripsContainer.TopToolStripPanel.SuspendLayout();
            this.StripsContainer.SuspendLayout();
            this.status.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            this.chart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Location = new System.Drawing.Point(0, 0);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(565, 397);
            this.chart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.chart.TabIndex = 0;
            this.chart.TabStop = false;
            // 
            // data
            // 
            this.data.AllowUserToResizeRows = false;
            this.data.AutoGenerateColumns = false;
            this.data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AColumn,
            this.BColumn,
            this.CColumn});
            this.data.DataSource = this.bs;
            this.data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data.Location = new System.Drawing.Point(0, 0);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(285, 397);
            this.data.TabIndex = 2;
            // 
            // menu
            // 
            this.menu.Dock = System.Windows.Forms.DockStyle.None;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.daneToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(854, 24);
            this.menu.TabIndex = 5;
            this.menu.Text = "menuStrip1";
            // 
            // daneToolStripMenuItem
            // 
            this.daneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zapiszDaneToolStripMenuItem,
            this.zapiszWykresJakoToolStripMenuItem,
            this.toolStripSeparator2,
            this.ustawieniaWykresuToolStripMenuItem,
            this.toolStripSeparator1,
            this.zakończToolStripMenuItem});
            this.daneToolStripMenuItem.Name = "daneToolStripMenuItem";
            this.daneToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.daneToolStripMenuItem.Text = "Dane";
            // 
            // zapiszDaneToolStripMenuItem
            // 
            this.zapiszDaneToolStripMenuItem.Name = "zapiszDaneToolStripMenuItem";
            this.zapiszDaneToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.zapiszDaneToolStripMenuItem.Text = "Zapisz dane...";
            // 
            // zapiszWykresJakoToolStripMenuItem
            // 
            this.zapiszWykresJakoToolStripMenuItem.Name = "zapiszWykresJakoToolStripMenuItem";
            this.zapiszWykresJakoToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.zapiszWykresJakoToolStripMenuItem.Text = "Zapisz wykres...";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(183, 6);
            // 
            // ustawieniaWykresuToolStripMenuItem
            // 
            this.ustawieniaWykresuToolStripMenuItem.Name = "ustawieniaWykresuToolStripMenuItem";
            this.ustawieniaWykresuToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.ustawieniaWykresuToolStripMenuItem.Text = "Ustawienia wykresu...";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(183, 6);
            // 
            // zakończToolStripMenuItem
            // 
            this.zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            this.zakończToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.zakończToolStripMenuItem.Text = "Zakończ";
            // 
            // SplitLayout
            // 
            this.SplitLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitLayout.IsSplitterFixed = true;
            this.SplitLayout.Location = new System.Drawing.Point(0, 0);
            this.SplitLayout.Name = "SplitLayout";
            // 
            // SplitLayout.Panel1
            // 
            this.SplitLayout.Panel1.Controls.Add(this.data);
            this.SplitLayout.Panel1MinSize = 0;
            // 
            // SplitLayout.Panel2
            // 
            this.SplitLayout.Panel2.Controls.Add(this.chart);
            this.SplitLayout.Panel2MinSize = 0;
            this.SplitLayout.Size = new System.Drawing.Size(854, 397);
            this.SplitLayout.SplitterDistance = 285;
            this.SplitLayout.TabIndex = 6;
            // 
            // przyciski
            // 
            this.przyciski.Dock = System.Windows.Forms.DockStyle.None;
            this.przyciski.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.przyciski.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DrawDataBtn});
            this.przyciski.Location = new System.Drawing.Point(3, 24);
            this.przyciski.Name = "przyciski";
            this.przyciski.Size = new System.Drawing.Size(58, 25);
            this.przyciski.TabIndex = 7;
            this.przyciski.Text = "Rysuj dane";
            // 
            // DrawDataBtn
            // 
            this.DrawDataBtn.Image = ((System.Drawing.Image)(resources.GetObject("DrawDataBtn.Image")));
            this.DrawDataBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DrawDataBtn.Name = "DrawDataBtn";
            this.DrawDataBtn.Size = new System.Drawing.Size(55, 22);
            this.DrawDataBtn.Text = "Rysuj";
            this.DrawDataBtn.Click += new System.EventHandler(this.DrawDataBtn_Click);
            // 
            // StripsContainer
            // 
            // 
            // StripsContainer.BottomToolStripPanel
            // 
            this.StripsContainer.BottomToolStripPanel.Controls.Add(this.status);
            // 
            // StripsContainer.ContentPanel
            // 
            this.StripsContainer.ContentPanel.AutoScroll = true;
            this.StripsContainer.ContentPanel.Controls.Add(this.SplitLayout);
            this.StripsContainer.ContentPanel.Size = new System.Drawing.Size(854, 397);
            this.StripsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StripsContainer.LeftToolStripPanelVisible = false;
            this.StripsContainer.Location = new System.Drawing.Point(0, 0);
            this.StripsContainer.Name = "StripsContainer";
            this.StripsContainer.RightToolStripPanelVisible = false;
            this.StripsContainer.Size = new System.Drawing.Size(854, 468);
            this.StripsContainer.TabIndex = 8;
            this.StripsContainer.Text = "toolStripContainer1";
            // 
            // StripsContainer.TopToolStripPanel
            // 
            this.StripsContainer.TopToolStripPanel.Controls.Add(this.menu);
            this.StripsContainer.TopToolStripPanel.Controls.Add(this.przyciski);
            // 
            // status
            // 
            this.status.Dock = System.Windows.Forms.DockStyle.None;
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.status.Location = new System.Drawing.Point(0, 0);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(854, 22);
            this.status.TabIndex = 9;
            this.status.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(839, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "Liczba danych : 0";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bs
            // 
            this.bs.DataSource = typeof(Gibbs.TernaryData);
            // 
            // AColumn
            // 
            this.AColumn.DataPropertyName = "A";
            dataGridViewCellStyle4.Format = "0.000";
            this.AColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.AColumn.HeaderText = "A%";
            this.AColumn.Name = "AColumn";
            // 
            // BColumn
            // 
            this.BColumn.DataPropertyName = "B";
            dataGridViewCellStyle5.Format = "0.000";
            this.BColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.BColumn.HeaderText = "B%";
            this.BColumn.Name = "BColumn";
            // 
            // CColumn
            // 
            this.CColumn.DataPropertyName = "C";
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle6.Format = "0.000";
            this.CColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.CColumn.HeaderText = "C%";
            this.CColumn.Name = "CColumn";
            this.CColumn.ReadOnly = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 468);
            this.Controls.Add(this.StripsContainer);
            this.MainMenuStrip = this.menu;
            this.Name = "frmMain";
            this.Text = "Diagram fazowy Gibbsa";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.SplitLayout.Panel1.ResumeLayout(false);
            this.SplitLayout.Panel2.ResumeLayout(false);
            this.SplitLayout.ResumeLayout(false);
            this.przyciski.ResumeLayout(false);
            this.przyciski.PerformLayout();
            this.StripsContainer.BottomToolStripPanel.ResumeLayout(false);
            this.StripsContainer.BottomToolStripPanel.PerformLayout();
            this.StripsContainer.ContentPanel.ResumeLayout(false);
            this.StripsContainer.TopToolStripPanel.ResumeLayout(false);
            this.StripsContainer.TopToolStripPanel.PerformLayout();
            this.StripsContainer.ResumeLayout(false);
            this.StripsContainer.PerformLayout();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox chart;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem daneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszDaneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszWykresJakoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ustawieniaWykresuToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem;
        private System.Windows.Forms.SplitContainer SplitLayout;
        private System.Windows.Forms.ToolStrip przyciski;
        private System.Windows.Forms.ToolStripContainer StripsContainer;
        private System.Windows.Forms.ToolStripButton DrawDataBtn;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.BindingSource bs;
        private System.Windows.Forms.DataGridViewTextBoxColumn AColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CColumn;
    }
}

