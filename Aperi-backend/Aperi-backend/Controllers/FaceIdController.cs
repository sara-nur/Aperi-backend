using Aperi_backend.Database;
using Aperi_backend.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace Aperi_backend.Controllers
{
    [ApiController]
    public class FaceIdController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;
        public FaceIdController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpPost]
        [Route("api/face-id-auth")]
        public ActionResult FaceIdAuth([FromBody] dtoAuth auth)
        {
            var card = _appDbContext.NfcCodes.ToList()
                .Where(card => card.IsScanned == true).FirstOrDefault();

            if (card != null)
            {
                card.isFaceIdValid = auth.isAuthorized;
                card.IsScanned = false;
                _appDbContext.Update(card);
                _appDbContext.SaveChanges();
                return Ok();
            }
            return BadRequest();
        }
    }
}
