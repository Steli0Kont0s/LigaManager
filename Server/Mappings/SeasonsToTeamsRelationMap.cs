using FluentNHibernate.Mapping;
using Server.Models;

namespace Server.Mappings
{
	class SeasonsToTeamsRelationMap : ClassMap<SeasonsToTeamsRelation>
	{
		public SeasonsToTeamsRelationMap()
		{
			Table("SeasonsToTeamsRelation");

			Id(x => x.Id).GeneratedBy.Native();

			References(x => x.Season).Column("SeasonId").Not.Nullable();
			References(x => x.Team).Column("TeamId").Not.Nullable();
		}
	}
}
