using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class Book
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(50)]
        public String Name { get; set; }
        public String ImageUrl { get; set; }
        public String ThumbnailImageUrl { get; set; }
        [MaxLength(300)]
        public String Description { get; set; }
        public int Rating { get; set; }
        public DateTime DateAdded { get; set; }
        public decimal NormalPrice { get; set; }
        public decimal PromoPrice { get; set; }
        public int Quantity { get; set; }
        [MaxLength(100)]
        public String Batch { get; set; }
        public int Views { get; set; }
        public IEnumerable<BookAuthor> Authors { get; set; }
        public bool IsEditorsPick { get; set; }

        public Genre Genre { get; set; }

    }
}
