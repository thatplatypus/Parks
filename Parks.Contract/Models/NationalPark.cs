namespace Parks.Contract.Models
{
	public class NationalPark
	{
		public string Status { get; set; }

		public string WeatherInfo { get; set; }

		public string DirectionsInfo { get; set; }

		public object Addresses { get; set; }

		public object EntranceFees { get; set; }

		public object Topics { get; set; }

		public string Name { get; set; }

		public string Latitude { get; set; }

		public object Activities { get; set; }

		public object OperatingHours { get; set; }

		public string Url { get; set; }

		public string Longitude { get; set; }

		public object Contacts { get; set; }

		public object EntrancePasses { get; set; }

		public string ParkCode { get; set; }

		public string Designation { get; set; }

		public NationalParkImage[] Images { get; set; }

		public string FullName { get; set; }

		public string LatLong { get; set; }

		public string Id { get; set; }

		public string DirectionsUrl { get; set; }

		public string Description { get; set; }
	}
}

