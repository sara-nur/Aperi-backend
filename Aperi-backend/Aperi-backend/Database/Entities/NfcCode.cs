using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aperi_backend.Database.Entities
{
    [Table("nfc_codes")]
    public class NfcCode
    {
        [Column("id"),StringLength(14)]
        public string Id { get; set; }
        [Column("created_at")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
