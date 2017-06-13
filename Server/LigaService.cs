using Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Server
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
	public class LigaService : ILigaService
	{
		public string Test(string test)
		{
			return string.Format("You entered: {0}", test);
		}




		public List<Bettor> GetBettors()
		{
			return Database.GetBettors();
		}

		public Bettor GetBettorById(int id)
		{
			return Database.GetBettorById(id);
		}

		public void AddBettor(string firstName, string lastName, string nickName)
		{
			Database.AddBettor(firstName, lastName, nickName);
		}

		public void EditBettor(Bettor bettor, string firstName, string lastName, string nickName)
		{
			Database.EditBettor(bettor, firstName, lastName, nickName);
		}

		public void DeleteBettor(Bettor bettor)
		{
			Database.DeleteBettor(bettor);
		}




		public List<Team> GetTeams()
		{
			return Database.GetTeams();
		}

		public Team GetTeamById(int id)
		{
			return Database.GetTeamById(id);
		}

		public void AddTeam(string name)
		{
			Database.AddTeam(name);
		}

		public void EditTeam(Team team, string name)
		{
			Database.EditTeam(team, name);
		}

		public void DeleteTeam(Team team)
		{
			Database.DeleteTeam(team);
		}




		public List<Match> GetMatches()
		{
			return Database.GetMatches();
		}

		public Match GetMatchById(int id)
		{
			return Database.GetMatchById(id);
		}

		public void AddMatch(Season season, Team homeTeam, Team awayTeam, int homeTeamScore, int awayTeamScore, DateTime dateTime)
		{
			Database.AddMatch(season, homeTeam, awayTeam, homeTeamScore, awayTeamScore, dateTime);
		}

		public void EditMatch(Match match, int homeTeamScore, int awayTeamScore, DateTime dateTime)
		{
			Database.EditMatch(match, homeTeamScore, awayTeamScore, dateTime);
		}

		public void DeleteMatch(Match match)
		{
			Database.DeleteMatch(match);
		}




		public List<Season> GetSeasons()
		{
			return Database.GetSeasons();
		}

		public Season GetSeasonById(int id)
		{
			return Database.GetSeasonById(id);
		}

		public void AddSeason(string name, string description, DateTime dateTime)
		{
			Database.AddSeason(name, description, dateTime);
		}

		public void EditSeason(Season season, String name)
		{
			Database.EditSeason(season, name);
		}

		public void DeleteSeason(Season season)
		{
			Database.DeleteSeason(season);
		}




		public List<Bet> GetBets()
		{
			return Database.GetBets();
		}

		public Bet GetBetById(int id)
		{
			return Database.GetBetById(id);
		}

		public void AddBet(Bettor bettor, Match match, int homeTeamScore, int awayTeamScore)
		{
			Database.AddBet(bettor, match, homeTeamScore, awayTeamScore);
		}

		public void EditBet(Bet bet, int homeTeamScore, int awayTeamScore)
		{
			Database.EditBet(bet, homeTeamScore, awayTeamScore);
		}

		public void DeleteBet(Bet bet)
		{
			Database.DeleteBet(bet);
		}
	}
}
