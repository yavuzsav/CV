using CV.Entities.Interfaces;

namespace CV.Entities.Concrete
{
    [Dapper.Contrib.Extensions.Table("Skills")]
    public class Skill : IEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}