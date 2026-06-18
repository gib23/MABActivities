namespace MAB_Activities.Activities
{
    partial class Activity2
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
            lblTitle = new Label();
            dgvParticipants = new DataGridView();
            ParticipantID = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            ContactNumber = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            btnAdd = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvParticipants).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(24, 29);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(132, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "ACTIVITY 2";
            // 
            // dgvParticipants
            // 
            dgvParticipants.AllowUserToAddRows = false;
            dgvParticipants.AllowUserToResizeRows = false;
            dgvParticipants.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvParticipants.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvParticipants.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvParticipants.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvParticipants.Columns.AddRange(new DataGridViewColumn[] { ParticipantID, FullName, Address, ContactNumber, Email, Status });
            dgvParticipants.Location = new Point(24, 73);
            dgvParticipants.Name = "dgvParticipants";
            dgvParticipants.ReadOnly = true;
            dgvParticipants.RowHeadersVisible = false;
            dgvParticipants.RowHeadersWidth = 51;
            dgvParticipants.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvParticipants.Size = new Size(961, 485);
            dgvParticipants.TabIndex = 1;
            dgvParticipants.CellDoubleClick += dgvParticipants_CellDoubleClick;
            dgvParticipants.SelectionChanged += dgvParticipants_SelectionChanged;
            // 
            // ParticipantID
            // 
            ParticipantID.DataPropertyName = "ParticipantID";
            ParticipantID.HeaderText = "ID";
            ParticipantID.MinimumWidth = 6;
            ParticipantID.Name = "ParticipantID";
            ParticipantID.ReadOnly = true;
            // 
            // FullName
            // 
            FullName.DataPropertyName = "FullName";
            FullName.HeaderText = "Full Name";
            FullName.MinimumWidth = 6;
            FullName.Name = "FullName";
            FullName.ReadOnly = true;
            // 
            // Address
            // 
            Address.DataPropertyName = "Address";
            Address.HeaderText = "Address";
            Address.MinimumWidth = 6;
            Address.Name = "Address";
            Address.ReadOnly = true;
            // 
            // ContactNumber
            // 
            ContactNumber.DataPropertyName = "ContactNumber";
            ContactNumber.HeaderText = "Contact Number";
            ContactNumber.MinimumWidth = 6;
            ContactNumber.Name = "ContactNumber";
            ContactNumber.ReadOnly = true;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAdd.Location = new Point(523, 564);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(228, 60);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnDelete.Location = new Point(757, 564);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(228, 60);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Activity2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dgvParticipants);
            Controls.Add(lblTitle);
            Name = "Activity2";
            Size = new Size(1000, 650);
            Load += Activity2_Load;
            ((System.ComponentModel.ISupportInitialize)dgvParticipants).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private DataGridView dgvParticipants;
        private Button btnAdd;
        private Button btnDelete;
        private DataGridViewTextBoxColumn ParticipantID;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn ContactNumber;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Status;
    }
}
