using MAB_Activities.Activities;

namespace MAB_Activities
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("You are trying to exit", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes) { Application.Exit(); }

        }
        private void btnAct1_Click(object sender, EventArgs e)
        {
            Activity1 act1 = new Activity1();
            act1.Dock = DockStyle.Fill;

            pnlMain.Controls.Clear();

            pnlMain.Controls.Add(act1);
            act1.BringToFront();
        }

        private void btnAct2_Click(object sender, EventArgs e)
        {
            Activity2 act2 = new Activity2();
            act2.Dock = DockStyle.Fill;

            pnlMain.Controls.Clear();

            pnlMain.Controls.Add(act2);
            act2.BringToFront();
        }

    }
}
