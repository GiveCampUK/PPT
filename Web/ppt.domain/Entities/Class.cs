using System;

namespace ppt.domain.Entities
{
    public class Class
    {
        public string InstitutionId { get; set; }
        public string[] InstructorIds { get; set; }
        public string[] ServiceUserIds { get; set; }
        public DateTime StartDate { get; set; }
    }
}
