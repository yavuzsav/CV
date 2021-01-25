using System;
using CV.Entities.Interfaces;

namespace CV.Entities.Concrete
{
    [Dapper.Contrib.Extensions.Table("Experiences")]
    public class Experience : IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndTime { get; set; }
    }
}