namespace Aperi_backend.Helpers
{
    public static class CodeGenerator
    {
        public static string GetCode() {
            var rand = new Random();
            return rand.Next(0000, 9999).ToString();
        }
    }
}
