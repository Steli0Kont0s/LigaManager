using FluentNHibernate.Mapping;
using Server.Models;

namespace Server.Mappings
{
	class TeamMap : ClassMap<Team>
	{
		public TeamMap()
		{
			Table("Teams");

			Id(x => x.Id).GeneratedBy.Native();

			Map(x => x.Name).Length(300).Not.Nullable();
			//HasMany(x => x.HomeMatches).KeyColumn("HomeTeamId").Cascade.All().Inverse();
			//HasMany(x => x.AwayMatches).KeyColumn("AwayTeamId").Cascade.All().Inverse();
		}
	}
}