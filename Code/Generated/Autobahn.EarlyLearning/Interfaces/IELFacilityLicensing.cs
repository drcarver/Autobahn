//***************************************************************************
//* DomainName: Early Learning (EL) Interfaces (used by both models and View Models
//* FileName:   IELFacilityLicensing.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The IELFacilityLicensing Interface
     /// </summary>
    public partial interface IELFacilityLicensing : IAutobahnBase
    {
        /// <summary>
        /// The year, month and day on which a program or center received its initial license.
        /// </summary>
        System.DateTime? ContinuingLicenseDate { get; set; }

        /// <summary>
        /// The year, month and day on which a program or center received its initial license.
        /// </summary>
        System.DateTime? InitialLicensingDate { get; set; }

        /// <summary>
        /// The year, month and day on which a program or center received its initial license.
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// The year, month and day on which a program or center received its initial license.
        /// </summary>
        Guid? RefELFacilityLicensingStatusId { get; set; }

        /// <summary>
        /// The year, month and day on which a program or center received its initial license.
        /// </summary>
        Guid? RefLicenseExemptId { get; set; }

        /// <summary>
        /// The year, month and day on which a program or center received its initial license.
        /// </summary>
        System.Int32? StateLicensedFacilityCapacity { get; set; }

    }
}
