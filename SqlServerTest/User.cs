using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SqlServerTest ;

    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        
        [MaxLength(50)]
        public string name { get; set; }
        
        [MaxLength(50)]
        public string email { get; set; }
    }