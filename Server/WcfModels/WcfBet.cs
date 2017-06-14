using Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.WcfModels
{
	public class WcfBet
	{
		public int Id { get; set; }
		public DateTime Date { get; set; }
		public int HomeTeamScore { get; set; }
		public int AwayTeamScore { get; set; }
		public int MatchId { get; set; }
		public int BettorId { get; set; }

		public WcfBet() { }

		public WcfBet(Bet bet)
		{
			this.Id = bet.Id;
			this.Date = bet.Date;
			this.HomeTeamScore = bet.HomeTeamScore;
			this.AwayTeamScore = bet.AwayTeamScore;
			this.MatchId = bet.Match.Id;
		}
	}
}
