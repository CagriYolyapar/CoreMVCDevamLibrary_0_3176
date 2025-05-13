using CoreMVCDevam_0.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreMVCDevam_0.Models.Configurations
{
    public class BookTagConfiguration : BaseConfiguration<BookTag>
    {
        public override void Configure(EntityTypeBuilder<BookTag> builder)
        {
            base.Configure(builder);
            builder.Ignore(x => x.Id);
            builder.HasKey(x => new
            {
                x.BookId,
                x.TagId
            });
        }
    }
}
