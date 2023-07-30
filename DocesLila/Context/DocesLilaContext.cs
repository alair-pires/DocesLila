using DocesLila.Models;
using Microsoft.EntityFrameworkCore;

namespace DocesLila.Context
{
    public class DocesLilaContext : DbContext
    {
        public DocesLilaContext(DbContextOptions<DocesLilaContext> options) : base(options)
        {
        }
    }
}
