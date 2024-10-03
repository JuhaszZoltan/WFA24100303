namespace WFA24100303
{
    partial class FrmShoppingList
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txbNewItem = new TextBox();
            lbxShoppingList = new ListBox();
            btnDeleteSelected = new Button();
            btnClear = new Button();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // txbNewItem
            // 
            txbNewItem.Location = new Point(12, 12);
            txbNewItem.Name = "txbNewItem";
            txbNewItem.PlaceholderText = "type new item name here...";
            txbNewItem.Size = new Size(254, 32);
            txbNewItem.TabIndex = 0;
            // 
            // lbxShoppingList
            // 
            lbxShoppingList.FormattingEnabled = true;
            lbxShoppingList.ItemHeight = 25;
            lbxShoppingList.Location = new Point(12, 50);
            lbxShoppingList.Name = "lbxShoppingList";
            lbxShoppingList.SelectionMode = SelectionMode.MultiSimple;
            lbxShoppingList.Size = new Size(254, 379);
            lbxShoppingList.TabIndex = 1;
            // 
            // btnDeleteSelected
            // 
            btnDeleteSelected.BackColor = Color.LightCoral;
            btnDeleteSelected.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnDeleteSelected.Location = new Point(272, 63);
            btnDeleteSelected.Name = "btnDeleteSelected";
            btnDeleteSelected.Size = new Size(123, 68);
            btnDeleteSelected.TabIndex = 2;
            btnDeleteSelected.Text = "DELETE selected";
            btnDeleteSelected.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.IndianRed;
            btnClear.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnClear.Location = new Point(272, 137);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(123, 68);
            btnClear.TabIndex = 2;
            btnClear.Text = "CLEAR all";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LightGreen;
            btnAdd.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnAdd.Location = new Point(272, 11);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(123, 46);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "ADD new";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // FrmShoppingList
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 442);
            Controls.Add(btnAdd);
            Controls.Add(btnClear);
            Controls.Add(btnDeleteSelected);
            Controls.Add(lbxShoppingList);
            Controls.Add(txbNewItem);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "FrmShoppingList";
            Text = "Shopping List";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbNewItem;
        private ListBox lbxShoppingList;
        private Button btnDeleteSelected;
        private Button btnClear;
        private Button btnAdd;
    }
}
