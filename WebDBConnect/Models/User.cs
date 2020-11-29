using System.ComponentModel.DataAnnotations;

namespace WebDBConnect.Models
{
    public class User
    {
        /// <summary>
        /// 사용자 번호 (PK)
        /// </summary>
        [Key]   // PrimaryKey 설정
        public int No { get; set; }
        /// <summary>
        /// 사용자 이름
        /// </summary>
        [Required]  // NotNull 설정
        public string Name { get; set; }
        /// <summary>
        /// 사용자 아이디
        /// </summary>
        [Required]  // NotNull 설정
        public string Id { get; set; }
        /// <summary>
        /// 사용자 비밀번호
        /// </summary>
        [Required]  // NotNull 설정
        public string Password { get; set; }
    }
}
