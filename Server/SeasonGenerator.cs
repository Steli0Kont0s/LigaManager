using Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
	class SeasonGenerator
	{
		private static DateTime mLastDate;
		private static int mMatchDay;

		public static void GenerateMatches(Season season, DateTime startDate)
		{
			List<Team[]> teams = new List<Team[]>();
			List<SeasonsToTeamsRelation> seasonTeams = season.TeamRelations.ToList();
			List<SeasonsToTeamsRelation> seasonTeams2 = season.TeamRelations.ToList();
			List<DateTime> gameDays = new List<DateTime>();
			int teamId;
			Team[] team;
			Random random = new Random();
			int gamesSaturday;
			int test = 0;

			mMatchDay = 1;

			foreach (Match match in season.Matches)
			{
				Database.DeleteMatch(match);
			}


			foreach(SeasonsToTeamsRelation home in seasonTeams)
			{
				foreach(SeasonsToTeamsRelation away in seasonTeams2)
				{
					if(home.TeamId != away.TeamId)
						teams.Add(new Team[] { Database.GetTeamById(home.TeamId), Database.GetTeamById(away.TeamId) });
				}
			}

			if(startDate.DayOfWeek != DayOfWeek.Friday)		// Wenn Anfang der Saison kein Freitag ist wähle nächsten Freitag
			{
				if ((int) startDate.DayOfWeek < 5)
					startDate = startDate.AddDays(5 - (int) startDate.DayOfWeek);
				else if ((int) startDate.DayOfWeek > 5)
					startDate = startDate.AddDays(7 - (int) startDate.DayOfWeek + 5);
			}
			startDate.Date.Date.Add(new TimeSpan(20, 30, 0));

			gameDays.Add(startDate);
			mLastDate = startDate;


			if(teams.Count()  <= 45) // 12 x Freitag + 11 x Samstag + 11 Sonntag => Mindestens 45 Spiele für 34 Spieltage
			{
				for(int i = 1; i < teams.Count(); i++)
				{
					gameDays.Add(GetNextMatchDay(mLastDate));
				}
			} 
			else if(teams.Count() > 45 ) // Ab 45 Spielen gibt es Samstage mit mehr als einem Spiel
			{
				int additionalSaturdayGames = (teams.Count() - 45) % 11;
				test = additionalSaturdayGames;
				gamesSaturday = (teams.Count() - 45) / 11;

				while(gameDays.Count() < teams.Count())
				{
					if (mLastDate.DayOfWeek == DayOfWeek.Friday)
					{
						mLastDate = GetNextMatchDay(mLastDate);
						int games = gamesSaturday;
						if (additionalSaturdayGames > 0)
						{
							games += 1;
							additionalSaturdayGames -= 1;
						}
						gameDays.AddRange(Enumerable.Repeat(mLastDate, games));
					}
					else
					{
						mLastDate = GetNextMatchDay(mLastDate);
						gameDays.Add(mLastDate);

					}
				}
				
			}

			int teamCount = teams.Count();
			for(int i = 0; i < teamCount; i++)
			{
				teamId = random.Next(0, teams.Count());
				team = teams.ElementAt(teamId);
				teams.RemoveAt(teamId);
				Database.AddMatch(season.Id, team[0], team[1], 0, 0, gameDays.ElementAt(i), mMatchDay);
				if(i+1 < teamCount)
				{
					if (gameDays.ElementAt(i).Day != gameDays.ElementAt(i + 1).Day)
						mMatchDay++;
				}
			}
		}



		private static DateTime GetNextMatchDay(DateTime lastDate)
		{
			DayOfWeek day = lastDate.DayOfWeek;
			if(day == DayOfWeek.Sunday)
			{
				if (lastDate.Hour < 17)
				{
					lastDate = lastDate.Date.Add(new TimeSpan(17, 30, 0));
				}
				else
				{
					lastDate = lastDate.Date.Add(new TimeSpan(20, 30, 0));
					lastDate = lastDate.AddDays(5);
				}

			}
			else if(day == DayOfWeek.Friday)
			{
				lastDate = lastDate.Date.Add(new TimeSpan(15, 30, 0));
				lastDate = lastDate.AddDays(1);
			}
			else if (day == DayOfWeek.Saturday)
			{
				lastDate = lastDate.Date.Add(new TimeSpan(15, 30, 0));
				lastDate = lastDate.AddDays(1);
			}
			else
			{
				lastDate = lastDate.Date.Add(new TimeSpan(20, 30, 0));
				lastDate = lastDate.AddDays(5 - (int) day);
			}

			return lastDate;
		}
	}
}
