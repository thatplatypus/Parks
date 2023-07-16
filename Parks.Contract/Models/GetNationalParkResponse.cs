using System;
namespace Parks.Contract.Models
{
	public class GetNationalParkResponse
	{
		public string Total { get; set; }

		public NationalPark[] Data { get; set; }

		public string Limit { get; set; }

		public string Start { get; set; }
	}
}

