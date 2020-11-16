using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebBanHang.Models
{
    public class CommentModel
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Vui lòng không bỏ trống bình luận")]
        [Display(Name = "Bình luận")]
        public string CommentContent { get; set; }
        public int IDProduct { get; set; }
        [ForeignKey("IDProduct")]
        public Product Product { get; set; }
    }
}