namespace ChurchDb.Controls
{
    partial class TextInput
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
            this.InputLabel = new System.Windows.Forms.Label();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.Location = new System.Drawing.Point(0, 0);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(78, 32);
            this.InputLabel.TabIndex = 0;
            this.InputLabel.Text = "label1";
            // 
            // InputTextBox
            // 
            this.InputTextBox.Location = new System.Drawing.Point(219, 0);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(554, 39);
            this.InputTextBox.TabIndex = 1;
            // 
            // TextInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.InputLabel);
            this.Name = "TextInput";
            this.Size = new System.Drawing.Size(804, 43);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label InputLabel;
        private TextBox InputTextBox;
    }
}
