using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nissim.On.PhoneBook.DL
{
    [Table("Person")]
    public class Person
    {
        [Key]
        [StringLength(30)]
        [Column("user_name")]
        public string UserName { get; set; }

        [StringLength(15)]
        [Column("password")]
        public string Password { get; set; }

        public virtual ICollection<Record> Records { get; set; }
    }
}
