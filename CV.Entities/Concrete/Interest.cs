using CV.Entities.Interfaces;

namespace CV.Entities.Concrete
{
    [Dapper.Contrib.Extensions.Table("Interests")]
    public class Interest : IEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}