namespace ChurchDb
{
    partial class Form1
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
            this.AddContactButton = new System.Windows.Forms.Button();
            this.ContactsDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ContactsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AddContactButton
            // 
            this.AddContactButton.Location = new System.Drawing.Point(45, 26);
            this.AddContactButton.Name = "AddContactButton";
            this.AddContactButton.Size = new System.Drawing.Size(234, 46);
            this.AddContactButton.TabIndex = 0;
            this.AddContactButton.Text = "Add Contact";
            this.AddContactButton.UseVisualStyleBackColor = true;
            this.AddContactButton.Click += new System.EventHandler(this.AddContactButton_Click);
            // 
            // ContactsDataGrid
            // 
            this.ContactsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ContactsDataGrid.Location = new System.Drawing.Point(45, 134);
            this.ContactsDataGrid.Name = "ContactsDataGrid";
            this.ContactsDataGrid.RowHeadersWidth = 82;
            this.ContactsDataGrid.RowTemplate.Height = 41;
            this.ContactsDataGrid.Size = new System.Drawing.Size(1077, 793);
            this.ContactsDataGrid.TabIndex = 2;
            this.ContactsDataGrid.DoubleClick += new System.EventHandler(this.ContactsDataGrid_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 969);
            this.Controls.Add(this.ContactsDataGrid);
            this.Controls.Add(this.AddContactButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ContactsDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button AddContactButton;
        private DataGridView ContactsDataGrid;
    }
}