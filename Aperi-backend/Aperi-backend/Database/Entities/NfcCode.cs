namespace Aperi_backend.Database.Entities
{
    public class NfcCode
    {
        public string CodeId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
