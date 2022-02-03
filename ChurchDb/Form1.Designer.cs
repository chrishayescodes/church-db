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
            this.ContactsListView = new System.Windows.Forms.ListView();
            this.chID = new System.Windows.Forms.ColumnHeader();
            this.chLast = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // AddContactButton
            // 
            this.AddContactButton.Location = new System.Drawing.Point(189, 195);
            this.AddContactButton.Name = "AddContactButton";
            this.AddContactButton.Size = new System.Drawing.Size(234, 46);
            this.AddContactButton.TabIndex = 0;
            this.AddContactButton.Text = "Add Contact";
            this.AddContactButton.UseVisualStyleBackColor = true;
            this.AddContactButton.Click += new System.EventHandler(this.AddContactButton_Click);
            // 
            // ContactsListView
            // 
            this.ContactsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chID,
            this.chLast});
            this.ContactsListView.Location = new System.Drawing.Point(189, 331);
            this.ContactsListView.Name = "ContactsListView";
            this.ContactsListView.Size = new System.Drawing.Size(1077, 529);
            this.ContactsListView.TabIndex = 1;
            this.ContactsListView.UseCompatibleStateImageBehavior = false;
            this.ContactsListView.View = System.Windows.Forms.View.Details;
            this.ContactsListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ContactsListView_MouseClick);
            // 
            // chID
            // 
            this.chID.Text = "ID";
            this.chID.Width = 150;
            // 
            // chLast
            // 
            this.chLast.Text = "Last Name";
            this.chLast.Width = 300;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 969);
            this.Controls.Add(this.ContactsListView);
            this.Controls.Add(this.AddContactButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button AddContactButton;
        private ListView ContactsListView;
        private ColumnHeader chID;
        private ColumnHeader chLast;
    }
}