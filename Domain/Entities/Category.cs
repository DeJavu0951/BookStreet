namespace Domain.Entities
{
    /// <summary>
    /// Lớp này chứa thông tin về thể loại sách
    /// </summary>
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
