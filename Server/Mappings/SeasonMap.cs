using FluentNHibernate.Mapping;
using Server.Models;

namespace Server.Mappings
{
	class SeasonMap : ClassMap<Season>
	{
		public SeasonMap()
		{
			Table("Seasons");

			Id(x => x.Id).GeneratedBy.Native();

			Map(x => x.Name).Length(300).Not.Nullable().Unique();
			Map(x => x.Description).Length(300);
			Map(x => x.Sequence).Not.Nullable().Unique();
			HasMany(x => x.TeamRelations).KeyColumn("SeasonId").Cascade.All().Inverse();
			HasMany(x => x.Matches).KeyColumn("SeasonId").Cascade.All().Inverse();

		}
	}
}