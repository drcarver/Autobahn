//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentActivityModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12StudentActivity Model
     /// </summary>
    public partial class K12StudentActivityModel : AutobahnBase, Interfaces.IK12StudentActivity
    {
        /// <summary>
        /// The amount of time the student participated in the events and procedures of an activity, such as a co-curricular or extra-curricular activity that is offered at an education institution.
        /// </summary>
        public System.Decimal? ActivityTimeInvolved { get; set; }

        /// <summary>
        /// The amount of time the student participated in the events and procedures of an activity, such as a co-curricular or extra-curricular activity that is offered at an education institution.
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// The amount of time the student participated in the events and procedures of an activity, such as a co-curricular or extra-curricular activity that is offered at an education institution.
        /// </summary>
        public Guid? RefActivityTimeMeasurementTypeId { get; set; }

    }
}
