using FluentNHibernate.Mapping;
using Server.Models;

namespace Server.Mappings
{
	class BettorMap : ClassMap<Bettor>
	{
		public BettorMap()
		{
			Table("Bettors");

			Id(x => x.Id).GeneratedBy.Native();

			Map(x => x.Firstname).Length(100).Not.Nullable();
			Map(x => x.Lastname).Length(100).Not.Nullable();
			Map(x => x.Nickname).Length(50).Not.Nullable().Unique();
			HasMany(x => x.Bets).KeyColumn("BettorId").Cascade.All().Inverse();
		}
	}
}
