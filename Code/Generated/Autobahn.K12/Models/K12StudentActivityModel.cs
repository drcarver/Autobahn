//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentActivityModel.cs
//* Name:       Activity Time Involved
//* Definition: The amount of time the student participated in the events and procedures of an activity, such as a co-curricular or extra-curricular activity that is offered at an education institution.
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The amount of time the student participated in the events and procedures of an activity, such as a co-curricular or extra-curricular activity that is offered at an education institution.
     /// </summary>
    public partial class K12StudentActivityModel : AutobahnBase, Interfaces.IK12StudentActivity
    {
        /// <summary>
        /// Activity Time Involved
        /// <para>
        /// The amount of time the student participated in the events and procedures of an activity, such as a co-curricular or extra-curricular activity that is offered at an education institution.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20502">Activity Time Involved</a>
        /// </para>
        /// </summary>
        public System.Decimal? ActivityTimeInvolved { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefActivityTimeMeasurementType"/> model
        /// </summary>
        public Guid? RefActivityTimeMeasurementTypeId { get; set; }

    }
}
