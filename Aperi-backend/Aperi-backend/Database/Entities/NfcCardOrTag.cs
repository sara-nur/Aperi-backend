using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aperi_backend.Database.Entities
{
    [Table("nfc_card_or_tag")]
    public class NfcCardOrTag
    {
        [Column("id"), StringLength(8)]
        public string? Id { get; set; }

        [Column("is_scanned")]
        public bool IsScanned { get; set; } = false;

        [Column("created_at")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [Column("is_code_valid")]
        public bool isCodeValid { get; set; } = false;

        [Column("is_face_id_valid")]
        public bool isFaceIdValid { get; set; } = false;

        [Column("is_fingerprint_valid")]
        public bool isFingerprintValid { get; set; } = false;
    }
}
