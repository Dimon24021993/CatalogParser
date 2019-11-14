using System;
using System.Windows.Forms;

namespace CatalogParser
{
    public partial class MainForm : Form
    {
        private readonly Replaces Replaces = new Replaces();
        private readonly ParseFiles ParseFiles = new ParseFiles();
        public MainForm()
        {
            InitializeComponent();
        }

        private void PriceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ClearControls();
            ParseFiles.Width = flowLayoutPanel1.Bounds.Width;
            flowLayoutPanel1.Controls.Add(ParseFiles);
        }

        private void ExitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ReplacesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ClearControls();
            Replaces.Width = flowLayoutPanel1.Bounds.Width;
            flowLayoutPanel1.Controls.Add(Replaces);
        }


        private void ClearControls()
        {
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is ISaver) (control as ISaver).SaveSettings();
            }
            flowLayoutPanel1.Controls.Clear();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ClearControls();
        }

        private void flowLayoutPanel1_Resize(object sender, EventArgs e)
        {
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                control.Width = flowLayoutPanel1.Bounds.Width;

            }

        }
    }
}
