    namespace HALAShop.Models
{
    using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


    [Table("Products")]
    public class MProduct
    {
        [Key]
        [Required]
        public int ID { get; set; }
        [Required(ErrorMessage = "Vui lòng chọn nhập tên sản phẩm")]
        public string Name { get; set; }
        public string Slug { get; set; }
        [Required(ErrorMessage = "Vui lòng chọn loại sản phẩm")]
        public int CateID { get; set; }
        public string Image { get; set; }
        public string Detail { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập mô tả sản phẩm")]
        public string MetaKey { get; set; }
        public string MetaDesc { get; set; }
        public int Status { get; set; }
        public DateTime Created_at { get; set; }
        public int Created_by { get; set; }
        public DateTime Updated_at { get; set; }
        public int Updated_by { get; set; }
    }
}