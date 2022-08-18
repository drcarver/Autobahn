//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELFacilityLicensingModel.cs
//* Name:       Continuing License Date
//* Definition: The year, month and day on which a program or center received its continuing license.
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The year, month and day on which a program or center received its continuing license.
     /// </summary>
    public partial class ELFacilityLicensingModel : AutobahnBase, Interfaces.IELFacilityLicensing
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
        public System.DateTime? ContinuingLicenseDate { get; set; }

        /// <summary>
        /// Initial License Date
        /// <para>
        /// The year, month and day on which a program or center received its initial license.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19347">Initial License Date</a>
        /// </para>
        /// </summary>
        public System.DateTime? InitialLicensingDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELFacilityLicensingStatus"/> model
        /// </summary>
        public Guid? RefELFacilityLicensingStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLicenseExempt"/> model
        /// </summary>
        public Guid? RefLicenseExemptId { get; set; }

        /// <summary>
        /// State Licensed Facility Capacity
        /// <para>
        /// The maximum number of children for which a state licensed a facility.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19865">State Licensed Facility Capacity</a>
        /// </para>
        /// </summary>
        public System.Int32? StateLicensedFacilityCapacity { get; set; }

    }
}
