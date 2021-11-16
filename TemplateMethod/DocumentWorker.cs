using Domain.Models;

namespace TemplateMethod
{
    public class DocumentWorker : Template<Document>
    {
        public DocumentWorker(List<Document> values) : base(values)
        {
        }

        public override List<Document> Sort()
        {
            return _values.OrderBy(d => d.Id).ToList();
        }
    }
}
