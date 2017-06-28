using Server.WcfModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TippspielClient
{
	class MatchDay
	{


		public List<WcfMatch> Matches { get; }
		public int Day { get; }
		public DateTime Date { get; }

		public MatchDay(List<WcfMatch> matches, int day)
		{
			Matches = (from match in matches
					  where match.MatchDay == day
					  select match).ToList();
			Day = day;
			Date = Matches.First().Date;
		}

	}
}
