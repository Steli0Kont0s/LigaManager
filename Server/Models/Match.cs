using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Models
{
	public class Match
	{
		public int Id { get; set; }
		public int MatchDay { get; set; }
		public DateTime Date { get; set; }
		public string GetDate
		{
			get
			{
				return this.Date.ToString("s");
			}
			set
			{
				this.Date = DateTime.Parse(value);
			}
		}
		public int HomeTeamScore { get; set; }
		public int AwayTeamScore { get; set; }
		public Team HomeTeam { get; set; }
		public Team AwayTeam { get; set; }
		//public Season Season { get; set; }
	}
}
