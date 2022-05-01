using System.Threading.Tasks;
using Transactions.Models;

namespace Transactions.Services
{
    public interface IAnimalDbService
    {
        Task<MethodResult> AddAnimalAsync(AnimalDTO animalDTO);
    }
}
