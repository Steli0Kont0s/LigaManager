using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Models
{
	public class Bettor
	{
		public int Id { get; set; }
		public string Nickname { get; set; }
		public string Firstname { get; set; }
		public string Lastname { get; set; }
		public IList<Bet> Bets { get; set; }

		public Bettor()
		{
			this.Bets = new List<Bet>();
		}
	}
}
