namespace CoreMVCDevam_0.Models.Entities
{
    public class Shelf : BaseEntity
    {
        public string ShelfCode { get; set; }
        public int? RoomId { get; set; }


        //Relational Properties
        public virtual ICollection<Book> Books { get; set; }
        public virtual Room Room { get; set; }
      



    }
}
