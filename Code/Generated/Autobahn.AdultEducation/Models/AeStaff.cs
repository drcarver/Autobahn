//**********************************************************
//* DomainName: Autobahn.AdultEducation
//* FileName:   AeStaff.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.AdultEducation.Models
{
     /// <summary>
     /// The AeStaff
     /// </summary>
    public partial class AeStaff : AutobahnBase, Interfaces.IAeStaff
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the AeStaff.YearsOfPriorAeTeachingExperience nullable property
        /// </summary>
        public System.Decimal? YearsOfPriorAeTeachingExperience { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAeStaffClassification"/> model
        /// </summary>
        public Guid? RefAeStaffClassificationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAeStaffEmploymentStatus"/> model
        /// </summary>
        public Guid? RefAeStaffEmploymentStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
