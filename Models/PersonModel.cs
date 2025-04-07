using SQLite;

namespace SQLiteDemo.Models
{
    public class PersonModel
    {
        [PrimaryKey, AutoIncrement]
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{PersonId} {FirstName} {LastName}";
    }
}
