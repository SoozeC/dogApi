using Newtonsoft.Json;
using System.Collections.Generic;

namespace DogApi.Models
{
    public class Dog
    {
        [JsonProperty("breed")]
        public string Breed { get; set; }

        [JsonProperty("colours")]
        public List<string> Colours { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("averageLifeSpan")]
        public string AverageLifeSpan { get; set; }

        [JsonProperty("origin")]
        public string Origin { get; set; }
    }
}
