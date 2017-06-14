using Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.WcfModels
{
	public class WcfMatch
	{
		public int Id { get; set; }
		public int MatchDay { get; set; }
		public DateTime Date { get; set; }
		public int HomeTeamScore { get; set; }
		public int AwayTeamScore { get; set; }
		public int HomeTeamId { get; set; }
		public int AwayTeamId { get; set; }
		public string HomeTeamName { get; set; }
		public string AwayTeamName { get; set; }
		public int SeasonId { get; set; }

		public WcfMatch() { }

		public WcfMatch(Match match)
		{
			this.Id = match.Id;
			this.MatchDay = match.MatchDay;
			this.Date = match.Date;
			this.HomeTeamId = match.HomeTeam.Id;
			this.AwayTeamId = match.AwayTeam.Id;
			this.HomeTeamName = match.HomeTeam.Name;
			this.AwayTeamName = match.AwayTeam.Name;
			this.HomeTeamScore = match.HomeTeamScore;
			this.AwayTeamScore = match.AwayTeamScore;
			this.SeasonId = match.Season.Id;
		}
	}
}
