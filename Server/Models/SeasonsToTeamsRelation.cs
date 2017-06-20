using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Models
{
	public class SeasonsToTeamsRelation
	{
		public int Id { get; set; }
		//public Season Season { get; set; }
		//public Team Team { get; set; }
		public int TeamId { get; set; }
		public int SeasonId { get; set; }
	}
}
