//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12StudentEmployment.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12StudentEmployment
     /// </summary>
    public partial class K12StudentEmployment : AutobahnBase, Interfaces.IK12StudentEmployment
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the K12StudentEmployment.EmploymentNaicsCode non nullable property
        /// </summary>
        public System.String EmploymentNaicsCode { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmployedWhileEnrolled"/> model
        /// </summary>
        public Guid? RefEmployedWhileEnrolledId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmployedAfterExit"/> model
        /// </summary>
        public Guid? RefEmployedAfterExitId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
