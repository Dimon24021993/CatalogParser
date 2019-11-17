using CatalogParser.Windows.FileParseSettings;
using CatalogParser.Windows.Replaces;
using CatalogParser.Windows.Totals;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CatalogParser
{
    public partial class MainForm : Form
    {
        private readonly Replace replaces = new Replace();
        private readonly ParseFiles parseFiles = new ParseFiles();
        private readonly Totals totals = new Totals();

        private IEnumerable<Control> ControlsList => new Control[] { replaces, totals, parseFiles };

        public MainForm()
        {
            InitializeComponent();
        }

        private void PriceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ClearControls();
            flowLayoutPanel1.Controls.Add(parseFiles);
        }

        private void ExitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ReplacesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ClearControls();
            flowLayoutPanel1.Controls.Add(replaces);
        }


        private void ClearControls()
        {
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is ISaver saver) saver.SaveSettings();

            }

            FlowLayoutPanel1_Resize(null, null);
            flowLayoutPanel1.Controls.Clear();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ClearControls();
        }


        private void FlowLayoutPanel1_Resize(object sender, EventArgs e)
        {
            foreach (var control in ControlsList)
            {
                control.Width = flowLayoutPanel1.Bounds.Width;
                control.Height = flowLayoutPanel1.Bounds.Height;
            }
        }

        private void OpenTotals(object sender, EventArgs e)
        {
            ClearControls();
            totals.Open(parseFiles.Settings, replaces.SettingsOrig);
            flowLayoutPanel1.Controls.Add(totals);
        }
    }
}
