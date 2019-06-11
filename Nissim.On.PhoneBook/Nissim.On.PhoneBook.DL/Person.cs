using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nissim.On.PhoneBook.DL
{
    [Table("Person")]
    public class Person
    {
        [Key]
        [Index(IsUnique = true)]
        [Column("person_id")]
        public int PersonId { get; set; }

        [StringLength(30)]
        [Column("user_name")]
        public string UserName { get; set; }

        [StringLength(15)]
        [Column("password")]
        public string Password { get; set; }
    }
}
