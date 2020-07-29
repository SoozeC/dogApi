using DogApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DogApi.Services
{
    public interface IDogService
    {
        IEnumerable<Dog> GetAllDogs();

        Dog GetDog(string breed);
    }
}
