using System.ComponentModel.DataAnnotations;

namespace ELTE.TodoList.Web.Models
{
    public class Item
    {
        [Key]
        public Int32 Id { get; set; }

        [MaxLength(30)]
        public String Name { get; set; } = null!;
        [DataType(DataType.MultilineText)]
        public String? Description { get; set; }
        public DateTime Deadline { get; set; }
        public byte[]? Image { get; set; }
        public Int32 ListId { get; set; }
        [Required]
        public virtual List List { get; set; } = null!;
    }
}
