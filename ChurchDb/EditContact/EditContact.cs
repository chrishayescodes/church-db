using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChurchDb.Contracts;
using ChurchDb.Controls;

namespace ChurchDb
{
    public partial class EditContact : Form, IEditContactForm
    {
        private readonly EditContactPresenter _presenter;
        private readonly EditContactState _state;
        private readonly ChurchContact _contact;

        private EditContact(EditContactPresenter presenter, EditContactState state, ChurchContact contact = null)
        {
            _presenter = presenter;
            _state = state;
            _contact = contact;
            InitializeComponent();
        }

        public event EventHandler? SaveRequested;
        public event EventHandler? CancelRequested;
        public ITextInput IDInput => IDTextInput;
        public ITextInput LastNameInput => LastNameTextInput;

        public void CloseForm()
        {
            this.Close();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            SaveRequested?.Invoke(this, EventArgs.Empty);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            CancelRequested?.Invoke(this, EventArgs.Empty);
        }

        private void EditContact_Load(object sender, EventArgs e)
        {
            if (_state == EditContactState.EDIT)
            {
                if (_contact == null)
                    throw new ArgumentNullException("contact parameter cannot be null when in edit mode.");
                this.IDInput.Text = _contact.ID;
                this.LastNameInput.Text = _contact.LastName;
            }

            _presenter.SetForm(this, _state);
        }

        public static EditContact CreateNew(EditContactPresenter presenter) =>
            new EditContact(presenter, EditContactState.NEW);

        public static EditContact Edit(EditContactPresenter presenter, ChurchContact contact) =>
            new EditContact(presenter, EditContactState.EDIT, contact);
    }
}
