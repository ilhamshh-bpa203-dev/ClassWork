using Fiorello.Models.Base;

namespace Fiorello.Models
{
    public class Card:BaseEntity
    {
        public string ImageURL{ get; set; }
        public string Name{ get; set; }
        public decimal Price{ get; set; }
    }
}
