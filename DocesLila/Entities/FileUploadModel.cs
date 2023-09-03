using Microsoft.AspNetCore.Http;

namespace DocesLila.Entities
{
    public class FileUploadModel
    {
        public IFormFile Arquivo { get; set; }
    }
}
