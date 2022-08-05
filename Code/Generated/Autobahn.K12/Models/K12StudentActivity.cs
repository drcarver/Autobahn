//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12StudentActivity.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12StudentActivity
     /// </summary>
    public partial class K12StudentActivity : AutobahnBase, Interfaces.IK12StudentActivity
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the K12StudentActivity.ActivityTimeInvolved nullable property
        /// </summary>
        public System.Decimal? ActivityTimeInvolved { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefActivityTimeMeasurementType"/> model
        /// </summary>
        public Guid? RefActivityTimeMeasurementTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
