using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aperi_backend.Database.Entities
{
    [Table("nfc_card_or_tag")]
    public class NfcCardOrTag
    {
        [Column("id"),StringLength(14)]
        public string Id { get; set; }
        [Column("created_at")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
