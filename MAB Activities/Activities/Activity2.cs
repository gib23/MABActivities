using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MAB_Activities.DatabaseConn;

namespace MAB_Activities.Activities
{
    public partial class Activity2 : UserControl
    {
        private int _selectedPart = 0;
        public Activity2()
        {
            InitializeComponent();
        }
        //METHODS//

        private void LoadParticipants() 
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    // SELECT all customers, most recently added first
                    string sql = @"SELECT 
                           ParticipantID,
                           FullName,
                           Address,
                           ContactNumber,
                           Email,
                           Status
                           FROM   Participants
                           ORDER  BY ParticipantID ASC;";

                    using (var adapter = new MySqlDataAdapter(sql, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Bind the DataTable to the grid
                        dgvParticipants.DataSource = dt;

                        // Improve column headers for readability
                        if (dgvParticipants.Columns.Count > 0)
                        {
                            dgvParticipants.Columns["ParticipantID"].HeaderText = "ID";
                            dgvParticipants.Columns["FullName"].HeaderText = "Full Name";
                            dgvParticipants.Columns["ContactNumber"].HeaderText = "Contact No.";
                            dgvParticipants.Columns["Status"].HeaderText = "Status";
                        }

                        lblTitle.Text = $"PARTICIPANTS LIST ({dt.Rows.Count} record(s))";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading customers:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void OpenEditForm()
        {
            if (_selectedPart == 0)
            {
                MessageBox.Show("Please select a customer to edit.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Open AddCustomerForm in EDIT mode, passing the selected CustomerID
            AddParticipant editForm = new AddParticipant(_selectedPart);

            // Refresh the grid automatically once the edit form closes
            editForm.FormClosed += (s, args) => LoadParticipants();

            editForm.ShowDialog(this);
        }
        private void DeleteParticipant(int ParticipantId)
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    // Parameterized DELETE — removes exactly one row
                    string sql = "DELETE FROM Participants WHERE ParticipantID = @ParticipantID;";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@ParticipantID", ParticipantId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Participant deleted successfully.",
                                "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LoadParticipants();   // Refresh the grid
                            _selectedPart = 0;   // Clear selection tracker
                        }
                        else
                        {
                            MessageBox.Show("Participant could not be deleted. It may no longer exist.",
                                "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting customer:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //EVENTS//
        private void Activity2_Load(object sender, EventArgs e)
        {
            LoadParticipants();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddParticipant addPart = new AddParticipant();
            addPart.ShowDialog();
            LoadParticipants();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedPart == 0)
            {
                MessageBox.Show("Please select a customer to delete.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Step 2: Confirm before deleting — this cannot be undone
            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to\ndelete this participant?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            // Step 3: Only delete if the user clicked Yes
            if (confirm == DialogResult.Yes)
            {
                DeleteParticipant(_selectedPart);
            }
        }

        private void dgvParticipants_SelectionChanged(object sender, EventArgs e)
        {
            // If no row is selected (e.g., grid is empty), do nothing
            if (dgvParticipants.CurrentRow == null) return;

            // Read the CustomerID value from the selected row
            var idCell = dgvParticipants.CurrentRow.Cells["ParticipantID"].Value;

            if (idCell != null && int.TryParse(idCell.ToString(), out int id))
            {
                _selectedPart = id;
            }
        }

        private void dgvParticipants_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            OpenEditForm();
        }
    }
}
