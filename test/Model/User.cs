using SQLite;

namespace test.Model
{
    [Table("User")]
    public class UserModel
    {
        [Column("Username")]
        public string? Username { get; set; }
        [Column("Password")]
        public string? Password { get; set; }
        [Column("Currency")]
        public string? Currency { get; set; }
    }
}
