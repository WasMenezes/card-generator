using CardGenerator.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CardGenerator.Core.Interfaces
{
    public interface ICardRepository
    {
        Task<IEnumerable<Card>> GetCardsByEmail(string email);
        Task<Card> GenerateCreditCard(string email);
    }
}
