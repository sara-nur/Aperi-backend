using System.ComponentModel.DataAnnotations.Schema;

namespace Aperi_backend.Database.Entities
{
    [Table("users")]
    public class User
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("first_name")]
        public string? FirstName { get; set; }
        [Column("last_name")]
        public string? LastName { get; set; }
        [Column("created_at")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        [Column("user_card_or_tag")]
        public virtual NfcCode? UserCardOrTag { get; set; }
    }
}
