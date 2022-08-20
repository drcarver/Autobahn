//**********************************************************
//* DomainName: Autobahn.Entities
//* FileName:   CourseSectionLocation.cs
//**********************************************************

using System.ComponentModel.DataAnnotations.Schema;
using Autobahn.Interfaces.Common;

namespace Autobahn.Entities.Common
{
    [Table("CourseSectionLocation", Schema = "Common")]
    public partial class CourseSectionLocation : EntityBase, ICourseSectionLocation
    {
        [ForeignKey("Classroom")]
        public Guid ClassroomId { get; set; }

        [ForeignKey("CourseSection")]
        public Guid CourseSectionId { get; set; }

        [ForeignKey("RefInstructionLocationType")]
        public Guid? RefInstructionLocationTypeId { get; set; }

        public virtual Classroom Classroom { get; set; }

        public virtual CourseSection CourseSection { get; set; }

        public virtual RefInstructionLocationType RefInstructionLocationType { get; set; }
    }
}
