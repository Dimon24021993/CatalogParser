using System;
using System.Windows.Forms;

namespace CatalogParser.Windows.Totals
{
    public partial class TotalsControls : UserControl
    {
        public event Action<ProgressBar> OnParse;
        public event Action OnExport;
        public TotalsControls()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OnParse?.Invoke(progressBar1);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OnExport?.Invoke();
        }
    }
}
