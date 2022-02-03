using ChurchDb.Contracts;
using ChurchDb.SqLitePersistence;

namespace ChurchDb
{
    public partial class Form1 : Form
    {
        private IChurchContactPersistence _persistence;

        public Form1()
        {
            InitializeComponent();
        }

        private void AddContactButton_Click(object sender, EventArgs e)
        {
            var addform = EditContact.CreateNew(new EditContactPresenter(_persistence));
            addform.ShowDialog();
            RefreshListView();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var persistence = new SqliteChurchContactPersistence();
            var dbfilename = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "churchcontacts.db");
            persistence.Init(dbfilename);
            _persistence = persistence;
            RefreshListView();
        }

        private void RefreshListView()
        {
            ContactsListView.Items.Clear();
            var contacts = _persistence.GetAll();
            foreach (var contact in contacts)
            {
                string[] row = new[] {contact.ID, contact.LastName};
                ListViewItem item = new ListViewItem(row);
                item.Tag = contact;
                ContactsListView.Items.Add(item);
            }
        }

        private void ContactsListView_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.ContactsListView.SelectedItems.Count > 0)
            {
                var addform = EditContact.Edit(new EditContactPresenter(_persistence), (ChurchContact)this.ContactsListView.SelectedItems[0].Tag);
                addform.ShowDialog();
                RefreshListView();
            }

        }
    }
}