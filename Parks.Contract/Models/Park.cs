using System;
namespace Parks.Contract.Models
{
	public class Park
	{
		public string Id { get; set; }

		public string Name { get; set; }

		public string Location { get; set; }

		public bool OffLeashDogArea { get; set; }
	}
}

