//***************************************************************************
//* DomainName: Early Learning (EL) Interfaces (used by both models and View Models
//* FileName:   IELFacilityLicensing.cs
//* Name:       Continuing License Date
//* Definition: 
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// 
     /// </summary>
    public partial interface IELFacilityLicensing : IAutobahnBase
    {
        /// <summary>
        /// Continuing License Date
        /// <para>
        /// The year, month and day on which a program or center received its continuing license.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19348">Continuing License Date</a>
        /// </para>
        /// </summary>
        System.DateTime? ContinuingLicenseDate { get; set; }

        /// <summary>
        /// Initial License Date
        /// <para>
        /// The year, month and day on which a program or center received its initial license.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19347">Initial License Date</a>
        /// </para>
        /// </summary>
        System.DateTime? InitialLicensingDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELFacilityLicensingStatus"/> model
        /// </summary>
        Guid? RefELFacilityLicensingStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLicenseExempt"/> model
        /// </summary>
        Guid? RefLicenseExemptId { get; set; }

        /// <summary>
        /// State Licensed Facility Capacity
        /// <para>
        /// The maximum number of children for which a state licensed a facility.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19865">State Licensed Facility Capacity</a>
        /// </para>
        /// </summary>
        System.Int32? StateLicensedFacilityCapacity { get; set; }

    }
}
