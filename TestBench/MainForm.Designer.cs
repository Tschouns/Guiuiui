namespace TestBench
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.layoutTable = new System.Windows.Forms.TableLayoutPanel();
            this.personListView = new System.Windows.Forms.ListView();
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.personTable = new System.Windows.Forms.TableLayoutPanel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.ageLagel = new System.Windows.Forms.Label();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.layoutTable.SuspendLayout();
            this.personTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutTable
            // 
            this.layoutTable.ColumnCount = 4;
            this.layoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.layoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutTable.Controls.Add(this.personListView, 1, 1);
            this.layoutTable.Controls.Add(this.personTable, 2, 1);
            this.layoutTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutTable.Location = new System.Drawing.Point(0, 0);
            this.layoutTable.Name = "layoutTable";
            this.layoutTable.RowCount = 4;
            this.layoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.layoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.layoutTable.Size = new System.Drawing.Size(802, 541);
            this.layoutTable.TabIndex = 0;
            // 
            // personListView
            // 
            this.personListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumn});
            this.personListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.personListView.GridLines = true;
            this.personListView.Location = new System.Drawing.Point(23, 17);
            this.personListView.Name = "personListView";
            this.personListView.Size = new System.Drawing.Size(294, 250);
            this.personListView.TabIndex = 0;
            this.personListView.UseCompatibleStateImageBehavior = false;
            this.personListView.View = System.Windows.Forms.View.Details;
            this.personListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.personListView_ItemSelectionChanged);
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "Name";
            this.nameColumn.Width = 200;
            // 
            // personTable
            // 
            this.personTable.ColumnCount = 2;
            this.personTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.personTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.personTable.Controls.Add(this.nameLabel, 0, 1);
            this.personTable.Controls.Add(this.firstNameLabel, 0, 2);
            this.personTable.Controls.Add(this.genderLabel, 0, 4);
            this.personTable.Controls.Add(this.nameTextBox, 1, 1);
            this.personTable.Controls.Add(this.firstNameTextBox, 1, 2);
            this.personTable.Controls.Add(this.genderComboBox, 1, 4);
            this.personTable.Controls.Add(this.ageLagel, 0, 3);
            this.personTable.Controls.Add(this.ageTextBox, 1, 3);
            this.personTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.personTable.Location = new System.Drawing.Point(323, 17);
            this.personTable.Name = "personTable";
            this.personTable.RowCount = 8;
            this.personTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.personTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.personTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.personTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.personTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.personTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.personTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.personTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.personTable.Size = new System.Drawing.Size(456, 250);
            this.personTable.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameLabel.Location = new System.Drawing.Point(3, 27);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(222, 27);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Last Name";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firstNameLabel.Location = new System.Drawing.Point(3, 54);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(222, 27);
            this.firstNameLabel.TabIndex = 1;
            this.firstNameLabel.Text = "First Name";
            this.firstNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.genderLabel.Location = new System.Drawing.Point(3, 108);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(222, 27);
            this.genderLabel.TabIndex = 2;
            this.genderLabel.Text = "Gender";
            this.genderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameTextBox.Location = new System.Drawing.Point(231, 30);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(222, 20);
            this.nameTextBox.TabIndex = 3;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firstNameTextBox.Location = new System.Drawing.Point(231, 57);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(222, 20);
            this.firstNameTextBox.TabIndex = 4;
            // 
            // genderComboBox
            // 
            this.genderComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Location = new System.Drawing.Point(231, 111);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(222, 21);
            this.genderComboBox.TabIndex = 5;
            // 
            // ageLagel
            // 
            this.ageLagel.AutoSize = true;
            this.ageLagel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ageLagel.Location = new System.Drawing.Point(3, 81);
            this.ageLagel.Name = "ageLagel";
            this.ageLagel.Size = new System.Drawing.Size(222, 27);
            this.ageLagel.TabIndex = 6;
            this.ageLagel.Text = "Age";
            this.ageLagel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ageTextBox
            // 
            this.ageTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ageTextBox.Location = new System.Drawing.Point(231, 84);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(222, 20);
            this.ageTextBox.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 541);
            this.Controls.Add(this.layoutTable);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.layoutTable.ResumeLayout(false);
            this.personTable.ResumeLayout(false);
            this.personTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutTable;
        private System.Windows.Forms.ListView personListView;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.TableLayoutPanel personTable;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.Label ageLagel;
        private System.Windows.Forms.TextBox ageTextBox;
    }
}

