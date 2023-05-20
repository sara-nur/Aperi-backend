namespace Aperi_backend.Helpers
{
    public static class CodeGeneratorHelper
    {
        public static string GetCode() {
            var rand = new Random();
            return rand.Next(1111, 9999).ToString();
        }
    }
}
