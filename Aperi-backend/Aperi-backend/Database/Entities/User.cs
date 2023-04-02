using System.ComponentModel.DataAnnotations;
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

        [ForeignKey(nameof(UserCardOrTag)), Column("nfc_id"),StringLength(14)]
        public string? NfcId { get; set; }

        [Column("user_card_or_tag")]
        public virtual NfcCode? UserCardOrTag { get; set; }
    }
}
