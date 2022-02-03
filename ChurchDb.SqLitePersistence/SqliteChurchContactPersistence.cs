using ChurchDb.Contracts;
using Dapper;
using Microsoft.Data.Sqlite;

namespace ChurchDb.SqLitePersistence
{
    public class SqliteChurchContactPersistence : IChurchContactPersistence
    {
        private string dbfilename;
        public void Init(string dbFilename)
        {
            dbfilename = dbFilename;
            if (File.Exists(dbFilename)) return;
            using var conn = new SqliteConnection($"Data Source={dbfilename}");
            conn.Open();
            string createTableQuery = @"CREATE TABLE IF NOT EXISTS [ChurchContacts] (
                          [ID] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                          [ContactLastName] NVARCHAR(2048)  NULL)";
            conn.Execute(createTableQuery);
        }

        public string Save(ChurchContact contact)
        {
            using var conn = new SqliteConnection($"Data Source={dbfilename};");
            conn.Execute(
                @"INSERT INTO [ChurchContacts] (ContactLastName) VALUES (@lastname)", 
                new { @lastname = contact.LastName });
            return conn.QueryFirst<int>("select last_insert_rowid();").ToString();// SELECT @@IDENTITY
        }

        public void Update(ChurchContact contact)
        {
            if (contact == null) throw new ArgumentNullException("argument 'contact' cannot be null");
            if (string.IsNullOrEmpty(contact.ID) || !int.TryParse(contact.ID, out int _))
                throw new ArgumentException($"the contact ID field value '{contact.ID}' must be parsable to an integer");
            using var conn = new SqliteConnection($"Data Source={dbfilename};");
            conn.Execute(
                @"UPDATE [ChurchContacts] SET ContactLastName = @lastname WHERE ID = @id",
                new { @lastname = contact.LastName, @id = int.Parse(contact.ID) });
        }

        public ChurchContact GetById(string id)
        {
            using var conn = new SqliteConnection($"Data Source={dbfilename};");
            return conn.QueryFirst<ChurchContact>(
                "SELECT ID as Id, ContactLastName as LastName FROM ChurchContacts WHERE ID = @id;", 
                new{@id = int.Parse(id)});
        }

        public IEnumerable<ChurchContact> GetAll()
        {
            using var conn = new SqliteConnection($"Data Source={dbfilename};");
            return conn.Query<ChurchContact>(@"SELECT ID, ContactLastName as LastName FROM ChurchContacts");
        }
    }
}