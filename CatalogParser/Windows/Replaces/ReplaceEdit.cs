using CatalogParser.Models;
using System;
using System.Windows.Forms;

namespace CatalogParser.Windows.Replaces
{
    public partial class ReplaceEdit : UserControl
    {
        private ReplaceModel ReplaceModel { get; set; }
        private bool Edit { get; set; }

        public ReplaceEdit()
        {
            InitializeComponent();
        }

        public event Action<ReplaceModel, ReplaceModel> OnEdit;
        public event Action<ReplaceModel> OnAdd;
        public event Action<ReplaceModel> OnDelete;

        public void OpenEdit(ReplaceModel replaceModel)
        {
            if (Edit)
            {
                var res =
                    !ReplaceModel.ItemNo.Equals(ItemNo.Text, StringComparison.CurrentCultureIgnoreCase) ||
                    !ReplaceModel.ReplaceNo.Equals(ReplaceNo.Text, StringComparison.CurrentCultureIgnoreCase)
                        ? MessageBox.Show("Вы уже редактируете запись. Сохранить изменения предидущей?",
                            "Сохранить изменения", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                        : DialogResult.No;
                switch (res)
                {
                    case DialogResult.Yes:
                        OnEdit?.Invoke(ReplaceModel, new ReplaceModel()
                        {
                            ItemNo = ItemNo.Text.ToUpperInvariant(),
                            ReplaceNo = ReplaceNo.Text.ToUpperInvariant()
                        });
                        break;
                    case DialogResult.No:
                        ReplaceModel = replaceModel;
                        ItemNo.Text = ReplaceModel.ItemNo.ToUpperInvariant();
                        ReplaceNo.Text = ReplaceModel.ReplaceNo.ToUpperInvariant();
                        break;
                    case DialogResult.Cancel:

                        break;
                }
            }
            else
            {
                ReplaceModel = replaceModel;
                ItemNo.Text = ReplaceModel.ItemNo.ToUpperInvariant();
                ReplaceNo.Text = ReplaceModel.ReplaceNo.ToUpperInvariant();
            }

            Edit = true;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (Edit)
            {
                OnEdit?.Invoke(ReplaceModel, new ReplaceModel()
                {
                    ItemNo = ItemNo.Text.ToUpperInvariant(),
                    ReplaceNo = ReplaceNo.Text.ToUpperInvariant()
                });
                Edit = false;
                ClearFields();
            }
            else
            {
                OnAdd?.Invoke(new ReplaceModel()
                {
                    ItemNo = ItemNo.Text.ToUpperInvariant(),
                    ReplaceNo = ReplaceNo.Text.ToUpperInvariant()
                });
                ClearFields();
            }
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            if (Edit)
            {
                OnDelete?.Invoke(ReplaceModel);
                Edit = false;
                ClearFields();
            }
            else
            {
                MessageBox.Show("Нечего удалять", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ClearFields()
        {
            ItemNo.Text = "";
            ReplaceNo.Text = "";
        }
    }
}
