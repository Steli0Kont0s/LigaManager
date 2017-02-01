using Server.WcfModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TippspielClient;

namespace TippspielClient.ViewModels
{
	class TeamHelper : WcfTeam
	{
		public WcfRelation Relation { get; set; }



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

		public WcfTeam GetTeam()
		{
			WcfTeam team = new WcfTeam();
			team.Id = this.Id;
			team.Name = this.Name;
			return team;
		}
	}
}
