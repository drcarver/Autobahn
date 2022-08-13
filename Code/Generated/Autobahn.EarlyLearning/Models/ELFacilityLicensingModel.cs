//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELFacilityLicensingModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The ELFacilityLicensing Model
     /// </summary>
    public partial class ELFacilityLicensingModel : AutobahnBase, Interfaces.IELFacilityLicensing
    {
        /// <summary>
        /// The year, month and day on which a program or center received its initial license.
        /// </summary>
        public System.DateTime? ContinuingLicenseDate { get; set; }

        /// <summary>
        /// The year, month and day on which a program or center received its initial license.
        /// </summary>
        public System.DateTime? InitialLicensingDate { get; set; }

        /// <summary>
        /// The year, month and day on which a program or center received its initial license.
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// The year, month and day on which a program or center received its initial license.
        /// </summary>
        public Guid? RefELFacilityLicensingStatusId { get; set; }

        /// <summary>
        /// The year, month and day on which a program or center received its initial license.
        /// </summary>
        public Guid? RefLicenseExemptId { get; set; }

        /// <summary>
        /// The year, month and day on which a program or center received its initial license.
        /// </summary>
        public System.Int32? StateLicensedFacilityCapacity { get; set; }

    }
}
