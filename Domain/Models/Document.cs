using Domain.Base;
using Domain.Enums;

namespace Domain.Models
{
    public  class Document : BaseModel<int>
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public Step Step { get; set; } = Step.Created;
    }
}
