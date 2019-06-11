using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nissim.On.PhoneBook.DL
{
    public class Record
    {
        [Key]
        [Index(IsUnique = true)]
        [Column("id")]
        public string Id { get; set; }

        [StringLength(30)]
        [Column("first_name")]
        public string FirstName { get; set; }

        [StringLength(30)]
        [Column("last_name")]
        public string LastName { get; set; }

        [StringLength(20)]
        [Column("phone_number")]
        public string PhoneNumber { get; set; }

        [StringLength(50)]
        [Column("address")]
        public string Address { get; set; }

        [MaxLength]
        [Column("image")]
        public string Image { get; set; }
    }
}
