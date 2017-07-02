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

			Map(x => x.TeamId).Not.Nullable().Unique();
			Map(x => x.SeasonId).Not.Nullable().Unique();



		}
	}
}
