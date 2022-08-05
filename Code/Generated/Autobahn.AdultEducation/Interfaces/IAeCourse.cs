//**********************************************************
//* DomainName: Autobahn.AdultEducation
//* FileName:   IAeCourse.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.AdultEducation.Interfaces
{
     /// <summary>
     /// The IAeCourse
     /// </summary>
    public partial interface IAeCourse : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseLevelType"/> model
        /// </summary>
        Guid? RefCourseLevelTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCareerCluster"/> model
        /// </summary>
        Guid? RefCareerClusterId { get; set; }

    }
}
