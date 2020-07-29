using DogApi.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DogApi.Services
{
    public class DogService : IDogService
    {
        public IEnumerable<Dog> GetAllDogs()
        {
            using (StreamReader r = new StreamReader("Data/dogBreeds.json"))
            {
                string json = r.ReadToEnd();
                return JsonConvert.DeserializeObject<List<Dog>>(json);
            }
        }

        public Dog GetDog(string breed)
        {
            using (StreamReader r = new StreamReader("Data/dogBreeds.json"))
            {
                string json = r.ReadToEnd();
                var fullList = JsonConvert.DeserializeObject<List<Dog>>(json);
                return fullList.SingleOrDefault(d => d.Breed.Equals(breed, System.StringComparison.OrdinalIgnoreCase));
            }
        }
    }
}