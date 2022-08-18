//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELProgramLicensingModel.cs
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
    public partial class ELProgramLicensingModel : AutobahnBase, Interfaces.IELProgramLicensing
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
        public System.DateTime? InitialLicenseDate { get; set; }

        /// <summary>
        /// Early Learning Program License Revocation Status
        /// <para>
        /// An indication of whether a program's license was revoked due to violations as determined by the state.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19838">Early Learning Program License Revocation Status</a>
        /// </para>
        /// </summary>
        public System.Boolean? LicenseRevocationStatus { get; set; }

        /// <summary>
        /// Early Learning Program License Suspension Status
        /// <para>
        /// An indication of whether a program's license was suspended due to violations as determined by the state.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19837">Early Learning Program License Suspension Status</a>
        /// </para>
        /// </summary>
        public System.Boolean? LicenseSuspensionStatus { get; set; }

        /// <summary>
        /// Number of Early Learning Fatalities
        /// <para>
        /// Number of child fatalities at the program in the past year, as defined by the State
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19835">Number of Early Learning Fatalities</a>
        /// </para>
        /// </summary>
        public System.Int32? NumberOfFatalities { get; set; }

        /// <summary>
        /// Number of Early Learning Injuries
        /// <para>
        /// Number of child injuries at the program in the past year, as defined by the State.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19836">Number of Early Learning Injuries</a>
        /// </para>
        /// </summary>
        public System.Int32? NumberOfInjuries { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELProgramLicenseStatus"/> model
        /// </summary>
        public Guid? RefELProgramLicenseStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLicenseExempt"/> model
        /// </summary>
        public Guid? RefLicenseExemptId { get; set; }

    }
}
