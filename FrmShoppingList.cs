namespace WFA24100303
{
    public partial class FrmShoppingList : Form
    {
        public FrmShoppingList()
        {
            InitializeComponent();
            btnAdd.Click += BtnAdd_Click;
            btnClear.Click += BtnClear_Click;
            btnDeleteSelected.Click += BtnDeleteSelected_Click;
        }

        private void BtnDeleteSelected_Click(object? sender, EventArgs e)
        {
            if (lbxShoppingList.SelectedItems.Count <= 0) return;

            if (IsConfirmed)
                while (lbxShoppingList.SelectedItems.Count > 0)lbxShoppingList.Items.Remove(lbxShoppingList.SelectedItems[0]);
        }

        private void BtnClear_Click(object? sender, EventArgs e)
        {
            if (IsConfirmed) lbxShoppingList.Items.Clear();
        }

        private void BtnAdd_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbNewItem.Text)) return;

            lbxShoppingList.Items.Add(txbNewItem.Text);
            txbNewItem.Text = string.Empty;

            txbNewItem.Focus();
        }

        private bool IsConfirmed
        {
            get
            {
                var res = MessageBox.Show(
                    caption: "WARNING!",
                    text: "R U sure?",
                    buttons: MessageBoxButtons.YesNo,
                    icon: MessageBoxIcon.Warning);
                return res == DialogResult.Yes;
            }
        }
    }
}
