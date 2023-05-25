using Aperi_backend.Database;
using Aperi_backend.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace Aperi_backend.Controllers
{
    [ApiController]
    public class FingerprintController : ControllerBase
    {

        private readonly AppDbContext _appDbContext;
        public FingerprintController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        [HttpPost]
        [Route("api/fingerprint-auth")]
        public ActionResult FingerprintAuth([FromBody] dtoAuth auth)
        {
            var card = _appDbContext.NfcCodes.ToList()
                .Where(card => card.IsScanned == true).FirstOrDefault();
            if (card != null)
            {
                card.isFingerprintValid = auth.isAuthorized;
                card.IsScanned = false;
                _appDbContext.Update(card);
                _appDbContext.SaveChanges();
                return Ok();
            }
            return BadRequest();
        }
    }
}
