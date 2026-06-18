using MAB_Activities.DatabaseConn;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAB_Activities.Activities
{
    public partial class AddParticipant : Form
    {
        private int _editPartId;

        public AddParticipant()
        {
            InitializeComponent();
            _editPartId = 0;
            lblTitle.Text = "NEW PARTICIPANT";
        }
        public AddParticipant(int _id)
        {
            InitializeComponent();

            _editPartId = _id;

            lblTitle.Text = "UPDATE PARTICIPANT";

            LoadParticipant(_id);
        }


        //METHODS//
        private void LoadParticipant(int partid)
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    string sql = @"SELECT FullName, Address, ContactNumber, Email, Status
                           FROM   Participants
                           WHERE  ParticipantID = @ParticipantID;";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@ParticipantID", partid);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtFullName.Text = reader.GetString("FullName");
                                txtAddress.Text = reader.GetString("Address");
                                txtCN.Text = reader.GetString("ContactNumber");
                                txtEmail.Text = reader.GetString("Email");
                                string dbStatus = reader.GetString("Status").Trim();

                                if (cmbStatus.Items.Contains(dbStatus))
                                {
                                    cmbStatus.SelectedItem = dbStatus;
                                }
                                else
                                {
                                    cmbStatus.SelectedIndex = -1; // Clears selection
                                }
                            }
                            else
                            {
                                MessageBox.Show("Participant record not found.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                this.Close();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading customer data:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearFields()
        {
            txtAddress.Text = "";
            txtCN.Text = "";
            txtEmail.Text = "";
            txtFullName.Text = "";
            cmbStatus.SelectedIndex = 0;
        }
        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Full Name is required.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFullName.Focus();
                return false;
            }

            // Check Address
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Address is required.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAddress.Focus();
                return false;
            }

            // Check Contact Number
            if (string.IsNullOrWhiteSpace(txtCN.Text))
            {
                MessageBox.Show("Contact Number is required.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCN.Focus();
                return false;
            }

            // Check Email
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Email is required.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            // Check Balance is a valid number
            if (string.IsNullOrWhiteSpace(cmbStatus.Text))
            {
                MessageBox.Show("Status is required.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbStatus.Focus();

                return false;
            }

            return true;
        }
        private void InsertParticipant()
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    // Parameterized INSERT — safe from SQL injection
                    string sql = @"INSERT INTO Participants
                               (FullName, Address, ContactNumber, Email, Status)
                           VALUES
                               (@FullName, @Address, @ContactNumber, @Email, @Status);";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        // Each @parameter safely carries one value from the form
                        cmd.Parameters.AddWithValue("@FullName", txtFullName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
                        cmd.Parameters.AddWithValue("@ContactNumber", txtCN.Text.Trim());
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@Status", cmbStatus.Text.Trim());

                        // ExecuteNonQuery runs INSERT/UPDATE/DELETE and
                        // returns the number of rows affected
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Customer saved successfully.",
                                "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            ClearFields();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving customer:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateParticipant()
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    string sql = @"UPDATE Participants
                           SET    FullName      = @FullName,
                                  Address       = @Address,
                                  ContactNumber = @ContactNumber,
                                  Email         = @Email,
                                  Status        = @Status
                           WHERE  ParticipantID = @ParticipantID;";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@FullName", txtFullName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
                        cmd.Parameters.AddWithValue("@ContactNumber", txtCN.Text.Trim());
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@Status", cmbStatus.Text.Trim());
                        cmd.Parameters.AddWithValue("@ParticipantID", _editPartId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Customer updated successfully.",
                                "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Update failed. The record may no longer exist.",
                                "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating customer:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //EVENTS//
        private void AddParticipant_Load(object sender, EventArgs e)
        {
            //cmbStatus.SelectedIndex = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            if (_editPartId == 0)
            {
                InsertParticipant();
            }
            else
            {
                UpdateParticipant();
            }
        }
    }
}
