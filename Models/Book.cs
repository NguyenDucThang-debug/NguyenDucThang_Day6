using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NguyenDucThang_Day6.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên sách không được để trống")]
        [Display(Name = "Tên Sách")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Tên tác giả không được để trống")]
        [Display(Name = "Tác giả")]
        public string Author { get; set; } = string.Empty;

        [Display(Name = "Ngày xuất bản")]
        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; }

        [Display(Name = "Số trang")]
        public int PageCount { get; set; }

        [Display(Name = "Danh mục")]
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public Category? Category { get; set; }
    }
}
