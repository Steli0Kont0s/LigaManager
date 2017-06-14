using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Server.Models;

namespace Server.WcfModels
{
	public class WcfBettor
	{
		public int Id { get; set; }
		public string Nickname { get; set; }
		public string Firstname { get; set; }
		public string Lastname { get; set; }

		public WcfBettor() { }

		public WcfBettor(Bettor bettor)
		{
			this.Id = bettor.Id;
			this.Nickname = bettor.Nickname;
			this.Firstname = bettor.Firstname;
			this.Lastname = bettor.Lastname;
		}
	}
}
