using System.ComponentModel.DataAnnotations;

namespace DocesLila.Entities
{
    public class Image
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public long Size { get; set; }
    }
}
