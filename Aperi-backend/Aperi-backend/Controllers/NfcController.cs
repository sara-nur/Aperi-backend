﻿using Aperi_backend.Database;
using Aperi_backend.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace Aperi_backend.Controllers
{
    [ApiController]
    public class NfcController : ControllerBase
    {
        private readonly ILogger _logger;
        private readonly AppDbContext _appDbContext;
        public NfcController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpGet]
        [Route("api/scan/{nfcId}")]
        public ActionResult<dtoScanned> Scan(string nfcId)
        {
            var scannedCard = _appDbContext.NfcCodes
                .Where(code => code.Id == nfcId)
                .FirstOrDefault();

            if (scannedCard != null)
            {
                scannedCard.IsScanned = true;
                _appDbContext.NfcCodes.Update(scannedCard);
                _appDbContext.SaveChanges();
                return Ok(new dtoScanned() { IsScanned = true });
            }
            return BadRequest();
        }

        [HttpGet]
        [Route("api/is-two-way-auth")]
        public ActionResult<bool> IsTwoWatAuth()
        {
            var cardOrTag = _appDbContext.NfcCodes
                .Where(card => card.isFaceIdValid
                 || card.isCodeValid
                 || card.isFingerprintValid).FirstOrDefault();
            if (cardOrTag != null)
            {
                cardOrTag.isCodeValid = false;
                cardOrTag.isFingerprintValid = false;
                cardOrTag.isFaceIdValid = false;
                _appDbContext.Update(cardOrTag);
                _appDbContext.SaveChanges();
                return Ok(true);
            }
            else
            {
                return Ok(false);
            }
        }
    }
}
