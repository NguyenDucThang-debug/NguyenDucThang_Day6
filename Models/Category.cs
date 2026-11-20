using System.ComponentModel.DataAnnotations;

namespace NguyenDucThang_Day6.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên danh mục không được để trống")]
        [Display(Name = "Danh mục sách")]
        public string Name { get; set; } = string.Empty;

        public ICollection<Book>? Books { get; set; }
    }
}
