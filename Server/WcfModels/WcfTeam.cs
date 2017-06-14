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

		public WcfTeam() { }

		public WcfTeam(Team team)
		{
			this.Id = team.Id;
			this.Name = team.Name;
		}
	}
}
