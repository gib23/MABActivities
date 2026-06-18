namespace MAB_Activities.Activities
{
    partial class AddParticipant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddParticipant));
            lblTitle = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnClear = new Button();
            btnClose = new Button();
            btnSave = new Button();
            txtFullName = new TextBox();
            txtAddress = new TextBox();
            txtCN = new TextBox();
            txtEmail = new TextBox();
            cmbStatus = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(23, 27);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(67, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "TITLE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 86);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 0;
            label2.Text = "Full Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 133);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 0;
            label3.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 180);
            label4.Name = "label4";
            label4.Size = new Size(118, 20);
            label4.TabIndex = 0;
            label4.Text = "Contact Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 227);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 0;
            label5.Text = "Email";
            // 
            // btnClear
            // 
            btnClear.BackgroundImage = (Image)resources.GetObject("btnClear.BackgroundImage");
            btnClear.BackgroundImageLayout = ImageLayout.Stretch;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Location = new Point(288, 321);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(50, 50);
            btnClear.TabIndex = 1;
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.BackgroundImage = (Image)resources.GetObject("btnClose.BackgroundImage");
            btnClose.BackgroundImageLayout = ImageLayout.Stretch;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(362, 321);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(50, 50);
            btnClose.TabIndex = 1;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.BackgroundImage = (Image)resources.GetObject("btnSave.BackgroundImage");
            btnSave.BackgroundImageLayout = ImageLayout.Stretch;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(214, 321);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(50, 50);
            btnSave.TabIndex = 1;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(149, 83);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(264, 27);
            txtFullName.TabIndex = 1;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(149, 130);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(264, 27);
            txtAddress.TabIndex = 2;
            // 
            // txtCN
            // 
            txtCN.Location = new Point(149, 177);
            txtCN.Name = "txtCN";
            txtCN.Size = new Size(264, 27);
            txtCN.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(149, 224);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(264, 27);
            txtEmail.TabIndex = 4;
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Active", "Inactive", "Banned", "Suspended" });
            cmbStatus.Location = new Point(149, 275);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(263, 28);
            cmbStatus.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 278);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Status";
            // 
            // AddParticipant
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 383);
            ControlBox = false;
            Controls.Add(cmbStatus);
            Controls.Add(txtEmail);
            Controls.Add(txtCN);
            Controls.Add(txtAddress);
            Controls.Add(txtFullName);
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            Controls.Add(btnClear);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AddParticipant";
            StartPosition = FormStartPosition.CenterScreen;
            Load += AddParticipant_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnClear;
        private Button btnClose;
        private Button btnSave;
        private TextBox txtFullName;
        private TextBox txtAddress;
        private TextBox txtCN;
        private TextBox txtEmail;
        private ComboBox cmbStatus;
        private Label label1;
    }
}