using CardGenerator.Core.Entities;
using CardGenerator.Core.Interfaces;
using CardGenerator.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGenerator.Infrastructure.Repositories
{
    public class CardRepository : ICardRepository
    {
        private readonly CardGeneratorContext _context;
        public CardRepository (CardGeneratorContext cardGeneratorContext)
        {
            _context = cardGeneratorContext;
        }
        public async Task<IEnumerable<Card>> GetCardsByEmail(string email)
        {
            var cards = await _context.Cards.Where(card => card.Email == email).ToListAsync();

            return cards;
        }

        public async Task<Card> GenerateCreditCard(string email)
        {
            Random rnd = new Random();
            string cardNumber = rnd.Next(10000000, 99999999).ToString();

            Card card = new Card();
            card.Email = email;
            card.CardNumber = cardNumber;

            var post = await _context.Cards.AddAsync(card);
            await _context.SaveChangesAsync();

            return post.Entity;
        }
    }
}
