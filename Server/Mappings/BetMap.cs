using FluentNHibernate.Mapping;
using Server.Models;

namespace Server.Mappings
{
	class BetMap : ClassMap<Bet>
	{
		public BetMap()
		{
			Table("Bets");

			Id(x => x.Id).GeneratedBy.Native();

			Map(x => x.GetDate).Column("DateTime").Not.Nullable();
			Map(x => x.HomeTeamScore).Not.Nullable();
			Map(x => x.AwayTeamScore).Not.Nullable();
			//References(x => x.Bettor).Column("BettorId").Not.Nullable();
			References(x => x.Match).Column("MatchId").Not.Nullable();
		}
	}
}