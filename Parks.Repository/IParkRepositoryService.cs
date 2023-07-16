using Parks.Contract.Models;

namespace Parks.Repository;

public interface IParkRepositoryService
{
    public IList<Park> GetParksAsync();

    public Park GetParkByIdAsync(string id);

    public Task<IEnumerable<NationalPark>> GetNationalParksAsync();

}

