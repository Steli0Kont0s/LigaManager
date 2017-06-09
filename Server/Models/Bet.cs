using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Models
{
	public class Bet
	{
		public int Id { get; set; }
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
		public Match Match { get; set; }
		public Bettor Bettor { get; set; }
	}
}
