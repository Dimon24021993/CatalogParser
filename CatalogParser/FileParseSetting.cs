using CatalogParser.Enums;
using CatalogParser.Extensions;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CatalogParser
{
    public partial class FileParseSetting : UserControl
    {
        public string FilePath { get; set; }
        public event Action<FileParseSetting> OnSave;
        public event Action<FileParseSetting> OnDelete;

        public FileParseSetting()
        {
            InitializeComponent();
            StoreType.DataSource = ((StoreType[])Enum.GetValues(typeof(Enums.StoreType))).Select(x => new
            {
                Name = EnumHelper<StoreType>.GetDisplayValue(x),
                Value = (int)x
            }).ToList();
            StoreType.ValueMember = "Value";
            StoreType.DisplayMember = "Name";
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;
            FilePath = openFileDialog.FileName;
            FileNameField.Text = openFileDialog.SafeFileName;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            OnSave?.Invoke(this);
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            OnDelete?.Invoke(this);
        }

        public void Clear()
        {
            StoreType.SelectedValue = 0;
            City.Text = "";
            ItemNo.Text = "";
            Quantity.Text = "";
            FilePath = "";
            FileNameField.Text = "";
        }
    }
}
