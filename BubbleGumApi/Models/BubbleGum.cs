using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BubbleGumApi.Models
{
    public class BubbleGum
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }
        public int CategoryId { get; set; }

        [JsonIgnore]
        public virtual Category Category{ get; set; }
    }
}
