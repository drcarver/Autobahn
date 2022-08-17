//**********************************************************
//* DomainName: Adult Education (AE)
//* FileName:   AeCourseModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.AdultEducation.Interfaces
{
     /// <summary>
     /// The AeCourse Model
     /// </summary>
    public partial class AeCourseModel : AutobahnBase, Interfaces.IAeCourse
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefCareerCluster"/> model
        /// </summary>
        public Guid? RefCareerClusterId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefCourseLevelType"/> model
        /// </summary>
        public Guid? RefCourseLevelTypeId { get; set; }

    }
}
