using BlazorSozluk.Api.Domain.Models;
using BlazorSozluk.Infrastucture.Persistence.Context;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;


namespace BlazorSozluk.Infrastucture.Persistence.EntityConfigurations.Entry
{
    public class EntryVoteEntityConfiguration : BaseEntityConfiguration<EntryVote>
    {
        public override void Configure(EntityTypeBuilder<EntryVote> builder)
        {
            base.Configure(builder);

            builder.ToTable("entryvote", BlazorSozlukContext.DEFAULT_SCHEMA);

            builder.HasOne(i => i.key)
                   .WithMany(i => i.EntryVotes)
                   .HasForeignKey(i => i.Key)   
        }
    }
}
