using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Server.Models;

namespace Server.WcfModels
{
	public class WcfSeason
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public int Sequence { get; set; }
		public DateTime StartDate { get; set; }

		public WcfSeason() { }

		public WcfSeason(Season season)
		{
			this.Id = season.Id;
			this.Name = season.Name;
			this.Description = season.Description;
			this.Sequence = season.Sequence;
			this.StartDate = season.StartDate;
		}
	}
}
