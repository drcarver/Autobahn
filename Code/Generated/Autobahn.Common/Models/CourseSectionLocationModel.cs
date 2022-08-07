//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   CourseSectionLocationModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The CourseSectionLocation Model
     /// </summary>
    public partial class CourseSectionLocationModel : AutobahnBase, Interfaces.ICourseSectionLocationModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Classroom"/> model
        /// </summary>
        public Guid ClassroomId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="CourseSection"/> model
        /// </summary>
        public Guid CourseSectionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefInstructionLocationType"/> model
        /// </summary>
        public Guid? RefInstructionLocationTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
