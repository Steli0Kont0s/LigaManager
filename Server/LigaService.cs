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
			return null;
		}

		public Bettor GetBettorById(int id)
		{
			return null;
		}

		public void AddBettor(string firstName, string lastName, string nickName)
		{

		}

		public void EditBettor(Bettor bettor, string firstName, string lastName, string nickName)
		{

		}

		public void DeleteBettor(Bettor bettor)
		{

		}




		public List<Team> GetTeams()
		{
			return null;
		}

		public Team GetTeamById(int id)
		{
			return null;
		}

		public void AddTeam(string name)
		{

		}

		public void EditTeam(Team team, string name)
		{

		}

		public void DeleteTeam(Team team)
		{

		}




		public List<Match> GetMatches()
		{
			return null;
		}

		public Match GetMatchById(int id)
		{
			return null;
		}

		public void AddMatch(Season season, Team homeTeam, Team awayTeam, int homeTeamScore, int awayTeamScore, DateTime dateTime)
		{

		}

		public void EditMatch(Match match, int homeTeamScore, int awayTeamScore, DateTime dateTime)
		{

		}

		public void DeleteMatch(Match match)
		{

		}




		public List<Season> GetSeasons()
		{
			return null;
		}

		public Season GetSeasonById(int id)
		{
			return null;
		}

		public void AddSeason(string name, string description, DateTime dateTime)
		{

		}

		public void EditSeason(Season season, String name)
		{

		}

		public void DeleteSeason(Season season)
		{

		}




		public List<Bet> GetBets()
		{
			return null;
		}

		public Bet GetBetById(int id)
		{
			return null;
		}

		public void AddBet(Bettor bettor, Match match, int homeTeamScore, int awayTeamScore)
		{

		}

		public void EditBet(Bet bet, int homeTeamScore, int awayTeamScore)
		{

		}

		public void DeleteBet(Bet bet)
		{

		}
	}
}
