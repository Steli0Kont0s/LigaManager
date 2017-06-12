using Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Server
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
	[ServiceContract]
	public interface ILigaService
	{
		[OperationContract]
		string Test(string Test);





		[OperationContract]
		List<Bettor> GetBettors();

		[OperationContract]
		Bettor GetBettorById(int id);

		[OperationContract]
		void AddBettor(string firstName, string lastName, string nickName);

		[OperationContract]
		void EditBettor(Bettor bettor, string firstName, string lastName, string nickName);

		[OperationContract]
		void DeleteBettor(Bettor bettor);




		[OperationContract]
		List<Team> GetTeams();

		[OperationContract]
		Team GetTeamById(int id);

		[OperationContract]
		void AddTeam(string name);

		[OperationContract]
		void EditTeam(Team team, string name);

		[OperationContract]
		void DeleteTeam(Team team);




		[OperationContract]
		List<Match> GetMatches();

		[OperationContract]
		Match GetMatchById(int id);

		[OperationContract]
		void AddMatch(Season season, Team homeTeam, Team awayTeam, int homeTeamScore, int awayTeamScore, DateTime dateTime);

		[OperationContract]
		void EditMatch(Match match, int homeTeamScore, int awayTeamScore, DateTime dateTime);

		[OperationContract]
		void DeleteMatch(Match match);




		[OperationContract]
		List<Season> GetSeasons();

		[OperationContract]
		Season GetSeasonById(int id);

		[OperationContract]
		void AddSeason(string name, string description, DateTime dateTime);

		[OperationContract]
		void EditSeason(Season season, String name);

		[OperationContract]
		void DeleteSeason(Season season);




		[OperationContract]
		List<Bet> GetBets();

		[OperationContract]
		Bet GetBetById(int id);

		[OperationContract]
		void AddBet(Bettor bettor, Match match, int homeTeamScore, int awayTeamScore);

		[OperationContract]
		void EditBet(Bet bet, int homeTeamScore, int awayTeamScore);

		[OperationContract]
		void DeleteBet(Bet bet);
	}
}
