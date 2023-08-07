using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DocesLila.Entities
{
    public class Product
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public string? Batch { get; set; }
        public string Description { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? Price { get; set; }
        public int? Quantity { get; set; }
        [Display(Name = "Registration Date")]
        [DataType(DataType.Date)]
        public DateTime RegistrationDate { get; set; }
        [Display(Name = "Expire Date")]
        [DataType(DataType.Date)]
        public DateTime? ExpireDate { get; set; }
    }
}
