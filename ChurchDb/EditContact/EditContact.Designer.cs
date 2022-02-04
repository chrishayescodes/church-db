namespace ChurchDb
{
    partial class EditContact
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
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.IDTextInput = new ChurchDb.Controls.TextInput();
            this.LastNameTextInput = new ChurchDb.Controls.TextInput();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(67, 340);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(150, 46);
            this.OKButton.TabIndex = 4;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(677, 340);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(150, 46);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // IDTextInput
            // 
            this.IDTextInput.Location = new System.Drawing.Point(67, 31);
            this.IDTextInput.Name = "IDTextInput";
            this.IDTextInput.Size = new System.Drawing.Size(790, 53);
            this.IDTextInput.TabIndex = 6;
            // 
            // LastNameTextInput
            // 
            this.LastNameTextInput.Location = new System.Drawing.Point(67, 105);
            this.LastNameTextInput.Name = "LastNameTextInput";
            this.LastNameTextInput.Size = new System.Drawing.Size(790, 53);
            this.LastNameTextInput.TabIndex = 7;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(366, 340);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(150, 46);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // EditContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 418);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.LastNameTextInput);
            this.Controls.Add(this.IDTextInput);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.Name = "EditContact";
            this.Text = "EditContact";
            this.Load += new System.EventHandler(this.EditContact_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Button OKButton;
        private Button CancelButton;
        private Controls.TextInput IDTextInput;
        private Controls.TextInput LastNameTextInput;
        private Button SaveButton;
    }
}