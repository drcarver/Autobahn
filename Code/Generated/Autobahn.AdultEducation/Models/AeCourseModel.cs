//**********************************************************
//* DomainName: Adult Education (AE)
//* FileName:   AeCourseModel.cs
//***************************************************************************

using Autobahn.Interfaces.AdultEducation;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.AdultEducation.Models
{
     /// <summary>
     /// The AeCourse Model
     /// </summary>
    public partial class AeCourseModel : AutobahnBase, IAeCourse
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Career Cluster
        /// <para>
        /// The career cluster that defines the industry or occupational focus which may be associated with a career pathways program, plan of study, or course.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20254">Career Cluster</a>
        /// </para>
        /// </summary>
        public Guid? RefCareerClusterId { get; set; }

        /// <summary>
        /// Course Level Type
        /// <para>
        /// The level of work which is reflected in the credits associated with the academic course being described or the level of the typical individual taking the academic course.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20278">Course Level Type</a>
        /// </para>
        /// </summary>
        public Guid? RefCourseLevelTypeId { get; set; }

    }
}
