using Parks.Contract.Models;

namespace Parks.Repository.Abstractions;

public interface IParkRepositoryService
{
    public IList<Park> GetParksAsync();

    public Park GetParkByIdAsync(string id);

}

