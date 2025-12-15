using Fiorello.Models.Base;

namespace Fiorello.Models
{
        public class Slider : BaseEntity
        {
            public string Header { get; set; }
            public string Description { get; set; }
            public string ImageURL { get; set; }
            public int Order { get; set; }

        }


}
