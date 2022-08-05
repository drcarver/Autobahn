//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   CourseSectionLevel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The CourseSectionLevel
     /// </summary>
    public partial class CourseSectionLevel : AutobahnBase, Interfaces.ICourseSectionLevel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="CourseSection"/> model
        /// </summary>
        public Guid CourseSectionId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefCourseLevelType"/> model
        /// </summary>
        public Guid RefCourseLevelTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
