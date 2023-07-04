using Microsoft.Extensions.Logging;
using Parks.Contract.Models;
using Parks.Repository;

namespace Parks.Domain.Services
{
	public class MockParkRepositoryService : IParkRepositoryService
	{
        private readonly ILogger<MockParkRepositoryService> _logger;

        public MockParkRepositoryService(ILogger<MockParkRepositoryService> logger)
		{
            _logger = logger;
        }

        public Park GetParkByIdAsync(string id)
        {
            return new Park
            {
                Id = id,
                Name = "Test Park",
                Location = "123 Red Onion Colorado Springs, CO 80918",
                OffLeashDogArea = false,
            };
        }

        public IList<Park> GetParksAsync()
        {
            return new Park[]
            {
                new Park
                {
                    Id = "1234",
                    Name = "Test Park",
                    Location = "123 Red Onion Colorado Springs, CO 80918",
                    OffLeashDogArea = false,
                },
                new Park
                {
                    Id = "5678",
                    Name = "Test Park 2",
                    Location = "456 Red Onion Colorado Springs, CO 80918",
                    OffLeashDogArea = false,
                },
            };
        }
    }
}

