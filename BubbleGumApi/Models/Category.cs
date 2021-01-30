using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BubbleGumApi.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
       
        [JsonIgnore]
        public virtual List<BubbleGum> bubbleGums { get; set; }
    }
}
