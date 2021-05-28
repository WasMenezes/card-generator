using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using CardGenerator.Core.Interfaces;
using CardGenerator.Infrastructure.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CardGenerator.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardController : ControllerBase
    {
        private readonly ICardRepository _cardRepository;
        public CardController(ICardRepository cardRepository)
        {
            _cardRepository = cardRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetCardsByEmail(string email)
        {
            var cards = await _cardRepository.GetCardsByEmail(email);
            return Ok(cards);
        }

        [HttpPost]
        public async Task<IActionResult> GenerateCreditCard(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return BadRequest(new { errorMessage = "Error: Email is Required." });
            }

            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (!match.Success)
            {
                return BadRequest(new { errorMessage = "Error: Invalid Email Provided." });
            }


            var card = await _cardRepository.GenerateCreditCard(email);
            return Ok(card);
        }
    }
}
