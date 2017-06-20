using Server.WcfModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.ViewModels
{
	class TeamHelper
	{
		public WcfRelation Relation { get; set; }
		public string Name { get; set; }
		public int Id { get; set; }


		public TeamHelper(WcfRelation relation)
		{
			WcfTeam team = WcfHelper.client.GetTeamById(relation.TeamId);
			this.Id = team.Id;
			this.Name = team.Name;
			this.Relation = relation;
		}

		public void Delete()
		{
			WcfHelper.client.DeleteRelation(this.Relation);
		}
	}
}
