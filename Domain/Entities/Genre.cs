﻿namespace Domain.Entities
{
    /// <summary>
    /// Lớp này chứa thông tin về thể loại sách
    /// </summary>
    public class Genre
    {
        public int GenreId { get; set; }
        public string Name { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
