namespace MAB_Activities.Activities
{
    partial class Activity1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Activity1));
            pnlPic = new Panel();
            btnBlue = new Button();
            btnRandom = new Button();
            btnClose = new Button();
            label1 = new Label();
            pnlPic.SuspendLayout();
            SuspendLayout();
            // 
            // pnlPic
            // 
            pnlPic.BackgroundImage = (Image)resources.GetObject("pnlPic.BackgroundImage");
            pnlPic.BackgroundImageLayout = ImageLayout.Stretch;
            pnlPic.Controls.Add(btnBlue);
            pnlPic.Controls.Add(btnRandom);
            pnlPic.Controls.Add(btnClose);
            pnlPic.Location = new Point(51, 110);
            pnlPic.Name = "pnlPic";
            pnlPic.Size = new Size(891, 436);
            pnlPic.TabIndex = 0;
            // 
            // btnBlue
            // 
            btnBlue.BackColor = Color.Transparent;
            btnBlue.BackgroundImageLayout = ImageLayout.None;
            btnBlue.FlatAppearance.BorderSize = 0;
            btnBlue.FlatAppearance.CheckedBackColor = Color.Transparent;
            btnBlue.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnBlue.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnBlue.FlatStyle = FlatStyle.Flat;
            btnBlue.Location = new Point(32, 268);
            btnBlue.Name = "btnBlue";
            btnBlue.Size = new Size(113, 128);
            btnBlue.TabIndex = 0;
            btnBlue.UseVisualStyleBackColor = false;
            btnBlue.Click += btnBlue_Click;
            // 
            // btnRandom
            // 
            btnRandom.BackColor = Color.Transparent;
            btnRandom.BackgroundImageLayout = ImageLayout.None;
            btnRandom.FlatAppearance.BorderSize = 0;
            btnRandom.FlatAppearance.CheckedBackColor = Color.Transparent;
            btnRandom.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnRandom.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnRandom.FlatStyle = FlatStyle.Flat;
            btnRandom.Location = new Point(208, 42);
            btnRandom.Name = "btnRandom";
            btnRandom.Size = new Size(113, 128);
            btnRandom.TabIndex = 0;
            btnRandom.UseVisualStyleBackColor = false;
            btnRandom.Click += btnRandom_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.BackgroundImageLayout = ImageLayout.None;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.CheckedBackColor = Color.Transparent;
            btnClose.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnClose.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(745, 42);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(113, 128);
            btnClose.TabIndex = 0;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(51, 55);
            label1.Name = "label1";
            label1.Size = new Size(288, 31);
            label1.TabIndex = 1;
            label1.Text = "FIND THE CLOSE BUTTON";
            // 
            // Activity1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(pnlPic);
            Name = "Activity1";
            Size = new Size(1000, 650);
            pnlPic.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlPic;
        private Button btnBlue;
        private Button btnRandom;
        private Button btnClose;
        private Label label1;
    }
}
