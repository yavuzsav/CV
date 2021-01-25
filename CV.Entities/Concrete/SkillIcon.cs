using CV.Entities.Interfaces;

namespace CV.Entities.Concrete
{
    [Dapper.Contrib.Extensions.Table("SkillIcons")]
    public class SkillIcon : IEntity
    {
        public int Id { get; set; }
        public string Icon { get; set; }
        public int SkillId { get; set; }
        public Skill Skill { get; set; }
    }
}