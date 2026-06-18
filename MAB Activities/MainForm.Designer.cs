namespace MAB_Activities
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnAct1 = new Button();
            btnAct2 = new Button();
            btnExit = new Button();
            pnlMain = new Panel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.0692043F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 79.93079F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(pnlMain, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1248, 664);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(btnAct1, 0, 0);
            tableLayoutPanel2.Controls.Add(btnAct2, 0, 1);
            tableLayoutPanel2.Controls.Add(btnExit, 0, 3);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.Size = new Size(244, 658);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // btnAct1
            // 
            btnAct1.Dock = DockStyle.Fill;
            btnAct1.FlatStyle = FlatStyle.Flat;
            btnAct1.Location = new Point(3, 3);
            btnAct1.Name = "btnAct1";
            btnAct1.Size = new Size(238, 54);
            btnAct1.TabIndex = 0;
            btnAct1.Text = "ACTIVITY 1";
            btnAct1.UseVisualStyleBackColor = true;
            btnAct1.Click += btnAct1_Click;
            // 
            // btnAct2
            // 
            btnAct2.Dock = DockStyle.Fill;
            btnAct2.FlatStyle = FlatStyle.Flat;
            btnAct2.Location = new Point(3, 63);
            btnAct2.Name = "btnAct2";
            btnAct2.Size = new Size(238, 54);
            btnAct2.TabIndex = 1;
            btnAct2.Text = "ACTIVITY 2";
            btnAct2.UseVisualStyleBackColor = true;
            btnAct2.Click += btnAct2_Click;
            // 
            // btnExit
            // 
            btnExit.Dock = DockStyle.Fill;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Location = new Point(3, 621);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(238, 34);
            btnExit.TabIndex = 2;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // pnlMain
            // 
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(253, 3);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(992, 658);
            pnlMain.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1248, 664);
            ControlBox = false;
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnAct1;
        private Button btnAct2;
        private Button btnExit;
        private Panel pnlMain;
    }
}
