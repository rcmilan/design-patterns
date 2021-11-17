using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using TemplateMethod;

namespace DesignPatterns.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TemplateMethodController : ControllerBase
    {
        [HttpGet("document")]
        public List<Document> GetDocs()
        {
            var docs = new List<Document>
            {
                new Document { Id = 31 },
                new Document { Id = 11 },
                new Document { Id = 21 }
            };

            DocumentWorker worker = new(docs);

            return worker.Sort();
        }

        [HttpGet("numeric")]
        public List<int> GetNumbers()
        {
            List<int> numbers = new() { 2, 1, 3 };

            NumericWorker numericWorker = new(numbers);

            return numericWorker.Get();
        }
    }
}
