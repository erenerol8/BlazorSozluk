using BlazorSozluk.Api.Domain.Models;

using BlazorSozluk.Infrastucture.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace BlazorSozluk.Infrastucture.Persistence.EntityConfigurations.Entry
{
    
    public class EntryFavoriteEntityConfiguration : BaseEntityConfiguration<EntryFavorite>
    {
        public override void Configure(EntityTypeBuilder<EntryFavorite> builder)
        {
            base.Configure(builder);

            builder.ToTable("entryfavorite", BlazorSozlukContext.DEFAULT_SCHEMA);

            builder.HasOne(i => i.Entry)
                    .WithMany(i => i.EntryFavorites)
                    .HasForeignKey(i => i.Entry);

            builder.HasOne(i => i.CreatedUser)
                    .WithMany(i => i.EntryFavorites)
                    .HasForeignKey(i => i.CreatedById);
                           
        }
    }
}
