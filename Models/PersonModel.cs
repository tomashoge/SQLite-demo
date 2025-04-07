using SQLite;

namespace SQLiteDemo.Models
{
    public class PersonModel
    {
        [PrimaryKey, AutoIncrement]
        public Guid PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTimeOffset Created { get; set; } = DateTimeOffset.Now;
        public string FullName => $"{PersonId} {FirstName} {LastName} {Created}";
    }
}
