using CV.Entities.Interfaces;

namespace CV.Entities.Concrete
{
    
    public class Reference : IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string IconLink { get; set; }
        public string ProjectLink { get; set; }
    }
}