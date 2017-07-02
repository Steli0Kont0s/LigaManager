using FluentNHibernate.Mapping;
using Server.Models;

namespace Server.Mappings
{
	class MatchMap : ClassMap<Match>
	{
		public MatchMap()
		{
			Table("Matches");

			Id(x => x.Id).GeneratedBy.Native();

			Map(x => x.GetDate).Column("DateTime").Not.Nullable();
			Map(x => x.HomeTeamScore).Not.Nullable();
			Map(x => x.AwayTeamScore).Not.Nullable();
			Map(x => x.MatchDay).Not.Nullable();
			Map(x => x.SeasonId).Not.Nullable();



			References(x => x.HomeTeam).Column("HomeTeamId").Not.Nullable();
			References(x => x.AwayTeam).Column("AwayTeamId").Not.Nullable();
		}
	}
}
