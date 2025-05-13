namespace CoreMVCDevam_0.Models.Entities
{
    public class Room : BaseEntity
    {
        public string RoomName { get; set; }

        //Relational Properties
        public virtual ICollection<Shelf> Shelves { get; set; }

    }
}
