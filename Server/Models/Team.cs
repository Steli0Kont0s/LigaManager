using System;
using System.Collections.Generic;

namespace Server.Models
{
	public class Team
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public IList<Match> HomeMatches { get; set; }
		public IList<Match> AwayMatches { get; set; }
	}
}
