using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class Comment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(300)]
        public string Text { get; set; }
        public DateTime DateAdded { get; set; }
        public virtual Comment ReplyTo { get; set; }
        public Boolean IsReply { get; set; }
    }
}