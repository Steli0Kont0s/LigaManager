using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Commands
{
	class Delete
	{
		public static void Bet(string id)
		{
			Database.DeleteBet(Database.GetBetById(int.Parse(id)));
		}

		public static void Bettor(string id)
		{
			Database.DeleteBettor(Database.GetBettorById(int.Parse(id)));
		}

		public static void Match(string id)
		{
			Database.DeleteMatch(Database.GetMatchById(int.Parse(id)));
		}

		public static void Season(string id)
		{
			Database.DeleteSeason(Database.GetSeasonById(int.Parse(id)));
		}

		public static void SeasonsToTeamsRelation(string id)
		{
			Database.DeleteSeasonsToTeamsRelation(Database.GetSeasonsToTeamsRelationById(int.Parse(id)));
		}

		public static void Team(string id)
		{
			Database.DeleteTeam(Database.GetTeamById(int.Parse(id)));
		}
	}
}
