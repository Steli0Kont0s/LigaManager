using Server.Models;
using Server.WcfModels;
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
		List<WcfBettor> GetAllBettors();

		[OperationContract]
		WcfBettor GetBettorById(int id);

		[OperationContract]
		void AddBettor(WcfBettor bettor);

		[OperationContract]
		void EditBettor(WcfBettor bettor);

		[OperationContract]
		void DeleteBettor(WcfBettor bettor);




		[OperationContract]
		List<WcfTeam> GetAllTeams();

		[OperationContract]
		List<WcfTeam> GetTeams(WcfSeason season);

		[OperationContract]
		WcfTeam GetTeamById(int id);

		[OperationContract]
		void AddTeam(WcfTeam team);

		[OperationContract]
		void EditTeam(WcfTeam team);

		[OperationContract]
		void DeleteTeam(WcfTeam team);

		[OperationContract]
		void AddTeamToSeason(WcfTeam team, WcfSeason season);

		[OperationContract]
		void DeleteTeamFromSeason(WcfTeam team, WcfSeason season);




		[OperationContract]
		List<WcfMatch> GetAllMatches();

		[OperationContract]
		List<WcfMatch> GetMatches(WcfSeason season);

		[OperationContract]
		WcfMatch GetMatchById(int id);

		[OperationContract]
		void AddMatch(WcfMatch match);

		[OperationContract]
		void EditMatch(WcfMatch match);

		[OperationContract]
		void DeleteMatch(WcfMatch match);

		[OperationContract]
		void GenerateMatches(WcfSeason season);




		[OperationContract]
		List<WcfSeason> GetAllSeasons();

		[OperationContract]
		WcfSeason GetSeasonById(int id);

		[OperationContract]
		void AddSeason(WcfSeason season);

		[OperationContract]
		void EditSeason(WcfSeason season);

		[OperationContract]
		void DeleteSeason(WcfSeason season);




		[OperationContract]
		List<WcfBet> GetAllBets();

		[OperationContract]
		List<WcfBet> GetBets(WcfBettor bettor);

		[OperationContract]
		WcfBet GetBetById(int id);

		[OperationContract]
		void AddBet(WcfBet bet);

		[OperationContract]
		void EditBet(WcfBet bet);

		[OperationContract]
		void DeleteBet(WcfBet bet);



		[OperationContract]
		List<WcfRelation> GetAllRelations();

		[OperationContract]
		List<WcfRelation> GetRelationsByTeam(WcfTeam team);

		[OperationContract]
		List<WcfRelation> GetRelationsBySeason(WcfSeason season);

		[OperationContract]
		void DeleteRelation(WcfRelation relation);
	}
}
