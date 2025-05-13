namespace CoreMVCDevam_0.Models.Entities
{
    public class Author : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Relational Properties
        public virtual ICollection<Book> Books { get; set; }

    }
}
