using Aperi_backend.Database;
using Aperi_backend.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;

namespace Aperi_backend.Controllers
{
    [ApiController]
    public class CodeAuthController : ControllerBase
    {
        private readonly AppDbContext _db;
        public CodeAuthController(AppDbContext db) {
            _db = db;
        }

        [HttpPost]
        [Route("api/get-code")]

        public ActionResult<string> SendCode([FromBody] string email)
        {


            #region user recognition 
            var scannedCard = _db.NfcCodes.ToList().Where(code=>code.IsScanned=true).FirstOrDefault();
            var user = _db.Users.ToList().Where(user => user.NfcId == scannedCard?.Id).FirstOrDefault();
            #endregion

            #region code generation
            var oneTimeCode = CodeGeneratorHelper.GetCode();
            #endregion

            #region preparing message and sending email
            var bodyText = $"<h2>Hello Dear, {user}</h2>" +
                $"<p>We are sending you your <strong>one time 4-digit</strong> authentification code: {oneTimeCode}</p>" +
                "<p>Please go to the app and type in your code. </p>" +
                "<br><p>Thank you for using Aperi</p>" +
                "<br><p>Sincerely<br>Your Aperi Team</p>";

            var message = new MailMessage()
            {
                From = new MailAddress("info.aperi@gmail.com"),
                Subject = "Aperi one-time authentification code",
                Body = bodyText,
                IsBodyHtml = true,
            };
            message.To.Add(email);

            EmailHelper.SendEmail(message);

            #endregion

            return Ok(new {oneTimeCode});
        }
    }
}
