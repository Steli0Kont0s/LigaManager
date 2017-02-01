using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Server.Models;

namespace Server.WcfModels
{
	public class WcfTeam
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public int Points { get; set; }
		public int Wins { get; set; }
		public int Defeats { get; set; }
		public int Draws { get; set; }
		public int GoalsDifference { get; set; }
		public int NumberOfGames { get; set; }
		public int Rank { get; set; }

		public WcfTeam() { }

		public WcfTeam(Team team)
		{
			this.Id = team.Id;
			this.Name = team.Name;
		}
	}
}
