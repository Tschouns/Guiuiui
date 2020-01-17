namespace Guiuiui.AddRemove.Buttons
{
    partial class StandardAddRemoveButtons
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.layoutTable = new System.Windows.Forms.TableLayoutPanel();
            this._addButton = new System.Windows.Forms.Button();
            this._removeButton = new System.Windows.Forms.Button();
            this.layoutTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutTable
            // 
            this.layoutTable.ColumnCount = 3;
            this.layoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.layoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutTable.Controls.Add(this._addButton, 0, 0);
            this.layoutTable.Controls.Add(this._removeButton, 2, 0);
            this.layoutTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutTable.Location = new System.Drawing.Point(0, 0);
            this.layoutTable.Margin = new System.Windows.Forms.Padding(0);
            this.layoutTable.Name = "layoutTable";
            this.layoutTable.RowCount = 1;
            this.layoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutTable.Size = new System.Drawing.Size(200, 30);
            this.layoutTable.TabIndex = 0;
            // 
            // _addButton
            // 
            this._addButton.AutoEllipsis = true;
            this._addButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._addButton.Enabled = false;
            this._addButton.Location = new System.Drawing.Point(0, 0);
            this._addButton.Margin = new System.Windows.Forms.Padding(0);
            this._addButton.Name = "_addButton";
            this._addButton.Size = new System.Drawing.Size(97, 30);
            this._addButton.TabIndex = 0;
            this._addButton.Text = "addButton";
            this._addButton.UseVisualStyleBackColor = true;
            // 
            // _removeButton
            // 
            this._removeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._removeButton.Enabled = false;
            this._removeButton.Location = new System.Drawing.Point(103, 0);
            this._removeButton.Margin = new System.Windows.Forms.Padding(0);
            this._removeButton.Name = "_removeButton";
            this._removeButton.Size = new System.Drawing.Size(97, 30);
            this._removeButton.TabIndex = 1;
            this._removeButton.Text = "removeButton";
            this._removeButton.UseVisualStyleBackColor = true;
            // 
            // StandardAddRemoveButtons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutTable);
            this.Name = "StandardAddRemoveButtons";
            this.Size = new System.Drawing.Size(200, 30);
            this.layoutTable.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutTable;
        private System.Windows.Forms.Button _addButton;
        private System.Windows.Forms.Button _removeButton;
    }
}
