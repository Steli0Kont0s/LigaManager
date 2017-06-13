using Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Commands
{
	class List
	{
		public static void Teams()
		{
			foreach(Team team in Database.GetTeams())
			{
				Console.WriteLine("{0} {1}", team.Id, team.Name);
			}
		}

		public static void Bets()
		{
			foreach (Bet bet in Database.GetBets())
			{
				Console.WriteLine("{0} {1} {2} {3}", bet.Id, bet.GetDate, bet.Match.MatchDay, bet.HomeTeamScore);
			}
		}

		public static void Bettors()
		{
			foreach (Bettor bettor in Database.GetBettors())
			{
				Console.WriteLine("{0} {1} {2} {3}", bettor.Id, bettor.Nickname, bettor.Firstname, bettor.Lastname);
				foreach (Bet bet in bettor.Bets)
				{
					Console.WriteLine("    {0} vs {1}", bet.Match.AwayTeam.Name, bet.Match.HomeTeam.Name);
				}
			}
		}

		public static void Matches()
		{
			foreach (Match match in Database.GetMatches())
			{
				Console.WriteLine("{0} {1} {2} {3}", match.Id, match.GetDate, match.AwayTeam.Name, match.HomeTeam.Name);
			}
		}

		public static void Seasons()
		{
			foreach (Season season in Database.GetSeasons())
			{
				Console.WriteLine(season.Name);
				foreach (SeasonsToTeamsRelation relation in season.TeamRelations)
				{
					Console.WriteLine(relation.Team.Name);
				}
				
			}
		}

		public static void SeasonsToTeamsRelations()
		{

		}
	}
}
