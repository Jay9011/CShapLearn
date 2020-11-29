using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebDBConnect.Models
{
    public class Note
    {
        /// <summary>
        /// 게시판 고유번호 (PK)
        /// </summary>
        [Key]
        public int No { get; set; }
        /// <summary>
        /// 게시판 제목
        /// </summary>
        [Required]  // NotNull 설정
        public string Title { get; set; }
        /// <summary>
        /// 게시판 내용
        /// </summary>
        [Required]  // NotNull 설정
        public string Content { get; set; }
        /// <summary>
        /// 유저 고유번호
        /// </summary>
        [Required]  // NotNull 설정
        public int UserNo { get; set; }
        [ForeignKey("UserNo")]  // ForeignKey 설정
        public virtual User User { get; set; }
    }
}
