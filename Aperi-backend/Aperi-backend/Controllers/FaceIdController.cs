using Aperi_backend.Database;
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
        public ActionResult FaceIdAuth([FromBody] bool auth)
        {
            var card = _appDbContext.NfcCodes.ToList()
                .Where(card => card.IsScanned == true).FirstOrDefault();

            card.isFaceIdValid= auth;
            card.IsScanned = false;
            _appDbContext.Update(card);
            _appDbContext.SaveChanges();
            return Ok();
        }
    }
}
