using System.ComponentModel.DataAnnotations;

namespace ELTE.TodoList.Web.Models
{
    public class List
    {
        public List()
        {
            Items = new HashSet<Item>();
        }

        [Key]
        public Int32 Id { get; set; }

        [MaxLength(30)]
        public String Name { get; set; } = null!;
        
        public virtual ICollection<Item> Items { get; set; }
    }
}
