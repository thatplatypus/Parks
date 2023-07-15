using System;
using Parks.Contract.Models;

namespace Parks.Server.NationalParks
{
	public interface INationalParkClient
	{
		public Task<object> GetNationalParkByStateAsync(string state);

		public Task<IEnumerable<Park>> GetNationalParksAsync();

		public Task<object> GetNationalParksTestAsync();
	}
}

