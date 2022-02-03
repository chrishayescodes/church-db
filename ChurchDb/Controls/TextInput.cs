using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChurchDb.Controls
{
    public partial class TextInput : UserControl, ITextInput
    {
        string ITextInput.Text
        {
            get => InputTextBox.Text;
            set => InputTextBox.Text = value;
        }

        bool ITextInput.Enabled
        {
            get => InputTextBox.Enabled;
            set => InputTextBox.Enabled = value;
        }
        public TextInput()
        {
            InitializeComponent();
        }

        public void SetLable(string text)
        {
            InputLabel.Text = text;
        }
    }

    public interface ITextInput
    {
        string Text { get; set; }
        void SetLable(string text);
        bool Enabled { get; set; }
    }
}
