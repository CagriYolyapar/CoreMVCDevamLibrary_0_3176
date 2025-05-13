namespace CoreMVCDevam_0.Models.Entities
{
    public class Tag : BaseEntity
    {
        public string Title { get; set; }

        //Relational Properties
        public virtual ICollection<BookTag> BookTags { get; set; }

    }
}
