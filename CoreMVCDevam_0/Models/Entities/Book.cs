namespace CoreMVCDevam_0.Models.Entities
{
    public class Book : BaseEntity
    {
        public string Title { get; set; }
        public int? AuthorId { get; set; }
        public int? CategoryId { get; set; }
        public int? ShelfId { get; set; }


        //Relational Properties
        public virtual Author Author { get; set; }
        public virtual Category Category { get; set; }
        public virtual Shelf Shelf { get; set; }
        public virtual ICollection<BookTag> BookTags { get; set; }


    }
}
