using Server.Framework;
using Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
	class Database
	{
		private static Repository<Bet> mBetRepository;
		private static Repository<Bettor> mBettorRepository;
		private static Repository<Match> mMatchRepository;
		private static Repository<Season> mSeasonRepository;
		private static Repository<SeasonsToTeamsRelation> mSeasonsToTeamsRelationRepository;
		private static Repository<Team> mTeamRepository;

		public static void Initialize(string database)
		{
			mBettorRepository = new Repository<Bettor>(database);
			mMatchRepository = new Repository<Match>(database);
			mBetRepository = new Repository<Bet>(database);
			mTeamRepository = new Repository<Team>(database);
			mSeasonRepository = new Repository<Season>(database);
			mSeasonsToTeamsRelationRepository = new Repository<SeasonsToTeamsRelation>(database);
		}

		// Database Interactions with Bettors
		// ==============================================================================================================================

		public static List<Bettor> GetBettors()
		{
			return mBettorRepository.GetAll();
		}

		public static Bettor GetBettorById(int id)
		{
			return mBettorRepository.GetById(id);
		}

		public static void AddBettor(string firstname, string lastname, string nickname)
		{
			if (mBettorRepository.GetByPropertyIgnoreCase("Nickname", nickname).Count == 0)
			{
				Bettor newBettor = new Bettor();

				newBettor.Firstname = firstname;
				newBettor.Lastname = lastname;
				newBettor.Nickname = nickname;
				mBettorRepository.Save(newBettor);
			}
			else
			{
				Console.WriteLine("Bettor existiert bereits");
			}
		}

		public static void EditBettor(Bettor bettor, string firstname, string lastname, string nickname)
		{
			bettor.Lastname = lastname;
			bettor.Firstname = firstname;

			if (bettor.Nickname.Equals(nickname))
			{
				mBettorRepository.Update(bettor);
			}
			else
			{
				if (mBettorRepository.GetByPropertyIgnoreCase("Nickname", nickname).Count == 0)
				{
					bettor.Nickname = nickname;
					mBettorRepository.Update(bettor);
				}
			}
		}

		public static Boolean DeleteBettor(Bettor bettor)
		{
			if(bettor.Bets == null || bettor.Bets.Count() == 0)
			{
				mBettorRepository.Delete(bettor);
				return true;
			}
			else
			{
				return false;
			}
			
		}

		// Database Interactions with Teams
		// ==============================================================================================================================

		public static List<Team> GetTeams()
		{
			return mTeamRepository.GetAll();
		}

		public static Team GetTeamById(int id)
		{
			return mTeamRepository.GetById(id);
		}

		public static void AddTeam(string name)
		{
			if(mTeamRepository.GetByPropertyIgnoreCase("Name", name).Count == 0)
			{
				Team newTeam = new Team();
				newTeam.Name = name;
				mTeamRepository.Save(newTeam);
			}
			else
			{
				Console.WriteLine("Team existiert bereits");
			}
		}

		public static void DeleteTeam(Team team)
		{
			mTeamRepository.Delete(team);
		}

		public static void EditTeam(Team team, string name)
		{
			if (mTeamRepository.GetByPropertyIgnoreCase("Name", name).Count == 0)
			{
				team.Name = name;
				mTeamRepository.Update(team);
			}
		}

		// Database Interactions with Matches
		// ==============================================================================================================================

		public static List<Match> GetMatches()
		{
			return mMatchRepository.GetAll();
		}

		public static Match GetMatchById(int id)
		{
			return mMatchRepository.GetById(id);
		}

		public static void AddMatch(Season season, Team home, Team away, int homeTeamScore, int awayTeamScore, DateTime dateTime)
		{
			Match newMatch = new Match();
			newMatch.AwayTeam = away;
			newMatch.HomeTeam = home;
			newMatch.AwayTeamScore = awayTeamScore;
			newMatch.HomeTeamScore = homeTeamScore;
			//newMatch.Season = season;
			newMatch.Date = dateTime;
			mMatchRepository.Save(newMatch);
		}

		public static void EditMatch(Match match, int homeTeamScore, int awayTeamScore, DateTime dateTime)
		{
			match.AwayTeamScore = awayTeamScore;
			match.HomeTeamScore = homeTeamScore;
			match.Date = dateTime;
			mMatchRepository.Update(match);
		}

		public static void DeleteMatch(Match match)
		{
			mMatchRepository.Delete(match);
		}

		// Database Interactions with Seasons
		// ==============================================================================================================================

		public static List<Season> GetSeasons()
		{
			return mSeasonRepository.GetAll();
		}

		public static Season GetSeasonById(int id)
		{
			return mSeasonRepository.GetById(id);
		}

		public static void AddSeason(string name, string description, DateTime startDate)
		{
			Season newSeason = new Season();
			newSeason.Name = name;
			newSeason.Description = description;
			newSeason.StartDate = startDate;
			// Sequence kommt hier her
		}

		public static void EditSeason(Season season, string name, string description, DateTime startDate)
		{
			season.Name = name;
			season.Description = description;
			season.StartDate = startDate;
			mSeasonRepository.Update(season);
		}

		public static void DeleteSeason(Season season)
		{
			mSeasonRepository.Delete(season);
		}

		// Database Interactions with SeasonsToTeamRelations
		// ==============================================================================================================================

		public static List<SeasonsToTeamsRelation> GetSeasonsToTeamsRelations()
		{
			return mSeasonsToTeamsRelationRepository.GetAll();
		}

		public static SeasonsToTeamsRelation GetSeasonsToTeamsRelationById(int id)
		{
			return mSeasonsToTeamsRelationRepository.GetById(id);
		}

		public static List<SeasonsToTeamsRelation> GetSeasonsToTeamsRelationsBySeasonId(int id)
		{
			return mSeasonsToTeamsRelationRepository.GetByProperty("SeasonId",id).ToList<SeasonsToTeamsRelation>();
		}

		public static List<SeasonsToTeamsRelation> GetSeasonsToTeamsRelationsByTeamId(int id)
		{
			return mSeasonsToTeamsRelationRepository.GetByProperty("TeamId", id).ToList<SeasonsToTeamsRelation>();
		}

		public static void DeleteSeasonsToTeamsRelation(SeasonsToTeamsRelation relation)
		{
			try
			{
				mSeasonsToTeamsRelationRepository.Delete(relation);

			}
			catch
			{

			}
		}

		public static void AddSeasonsToTeamsRelation(Team team, Season season)
		{
			SeasonsToTeamsRelation relation = new SeasonsToTeamsRelation()
			{
				TeamId = team.Id,
				SeasonId = season.Id
			};
			try
			{
				mSeasonsToTeamsRelationRepository.Save(relation);
			}
			catch
			{
				
			}
		}

		// Database Interactions with Bets
		// ==============================================================================================================================

		public static List<Bet> GetBets()
		{
			return mBetRepository.GetAll();
		}

		public static Bet GetBetById(int id)
		{
			return mBetRepository.GetById(id);
		}

		public static void AddBet(Bettor bettor, Match match, int homeTeamScore, int awayTeamScore)
		{
			Bet bet = new Bet();
			bet.Date = DateTime.Now;
			bet.HomeTeamScore = homeTeamScore;
			bet.AwayTeamScore = awayTeamScore;
			bet.Match = match;
			//bet.Bettor = bettor;
			mBetRepository.Save(bet);
		}

		public static void EditBet(Bet bet, int homeTeamScore, int awayTeamScore)
		{
			bet.HomeTeamScore = homeTeamScore;
			bet.AwayTeamScore = awayTeamScore;
			bet.Date = DateTime.Now;
			mBetRepository.Update(bet);
		}

		public static void DeleteBet(Bet bet)
		{
			mBetRepository.Delete(bet);
		}
	}
}
