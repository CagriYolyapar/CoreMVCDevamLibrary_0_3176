namespace CoreMVCDevam_0.Models.Entities
{
    public class BookTag : BaseEntity
    {
        public int BookId { get; set; }
        public int TagId { get; set; }

        //Relational Properties
        public virtual Book Book { get; set; }
        public virtual Tag Tag { get; set; }

    }
}
