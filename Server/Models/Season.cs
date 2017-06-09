using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Models
{
	public class Season
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public int Sequence { get; set; }
		public IList<SeasonsToTeamsRelation> TeamRelations { get; set; }
		public IList<Match> Matches { get; set; }
	}
}
