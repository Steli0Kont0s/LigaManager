using Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.WcfModels
{
	public class WcfRelation
	{
		public int Id { get; set; }
		public int SeasonId { get; set; }
		public int TeamId { get; set; }

		public WcfRelation() { }

		public WcfRelation(SeasonsToTeamsRelation relation)
		{
			this.Id = relation.Id;
			this.SeasonId = relation.SeasonId;
			this.TeamId = relation.TeamId;
		}
	}
}
