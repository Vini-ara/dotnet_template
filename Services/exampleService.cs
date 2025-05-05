using template.Entities;

namespace template.Services
{
    public class ExampleService
    {
      private readonly AppDbContext _context;

      public ExampleService(AppDbContext context)
      {
          _context = context;
      }
    }
}
