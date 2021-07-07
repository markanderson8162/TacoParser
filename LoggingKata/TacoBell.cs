using System;
using System.Collections.Generic;
using System.Text;

namespace LoggingKata
{
	class TacoBell : ITrackable
	{
		public TacoBell(double latitude, double longitude, string name)
		{
			Name = name;
			Location = new Point() { Latitude = latitude, Longitude = longitude }; 
		}
		public string Name { get; set; }
		public Point Location { get; set; }
	}
}
