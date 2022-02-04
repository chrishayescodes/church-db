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
            var persistence = new SqliteChurchContactPersistence(()=>DateTime.Now);
            var dbfilename = Path.Combine(
                Environment.GetFolderPath(
                    Environment.SpecialFolder.ApplicationData),
                "churchcontacts.db");
            persistence.Init(dbfilename);
            _persistence = persistence;
            RefreshListView();
        }

        private void RefreshListView()
        {
            var contacts = _persistence.GetAll().Select(c => new ChurchContact
            {
                ID = c.ID,
                LastName = c.LastName,
                CreatedOn = c.CreatedOn.ToLocalTime(),
                UpdatedOn = c.UpdatedOn.ToLocalTime()
            }).ToArray();

            ContactsDataGrid.DataSource = contacts;
        }

        private void ContactsDataGrid_DoubleClick(object sender, EventArgs e)
        {
            if (this.ContactsDataGrid.SelectedRows.Count > 0)
            {
                var addform = EditContact.Edit(new EditContactPresenter(_persistence), (ChurchContact)ContactsDataGrid.SelectedRows[0].DataBoundItem);
                addform.ShowDialog();
                RefreshListView();
            }
        }
    }

    internal static class DataHelpers
    {
        public static string ToLocalTimeString(this DateTime value) =>
            value.ToLocalTime().ToString("yyyy-MM-dd HH:mm:ss.sss");
    }
}