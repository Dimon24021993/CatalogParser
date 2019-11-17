﻿using System;
using System.Windows.Forms;

namespace CatalogParser.Windows.Replaces
{
    public partial class ReplaceSearch : UserControl
    {
        public event Action<string> OnSearch;

        public ReplaceSearch()
        {
            InitializeComponent();
        }

        public void Filter(object sender, System.EventArgs e)
        {
            OnSearch?.Invoke(textBox1.Text);
        }
    }
}
