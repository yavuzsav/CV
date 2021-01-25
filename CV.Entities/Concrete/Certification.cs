using CV.Entities.Interfaces;

namespace CV.Entities.Concrete
{
    [Dapper.Contrib.Extensions.Table("Certifications")]
    public class Certification : IEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}