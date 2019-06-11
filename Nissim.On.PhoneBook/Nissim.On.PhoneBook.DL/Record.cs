using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nissim.On.PhoneBook.DL
{
    [Table("Record")]
    public class Record
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("person_id")]
        public int PersonId { get; set; }

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

        [Column("is_active")]
        public bool IsActive { get; set; }

        [ForeignKey("PersonId")]
        public virtual Person Person { get; set; }
    }
}
