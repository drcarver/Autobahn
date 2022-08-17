//**********************************************************
//* DomainName: Adult Education (AE)
//* FileName:   AeStaffModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.AdultEducation.Interfaces
{
     /// <summary>
     /// The AeStaff Model
     /// </summary>
    public partial class AeStaffModel : AutobahnBase, Interfaces.IAeStaff
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefAeStaffClassification"/> model
        /// </summary>
        public Guid? RefAeStaffClassificationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefAeStaffEmploymentStatus"/> model
        /// </summary>
        public Guid? RefAeStaffEmploymentStatusId { get; set; }

        /// <summary>
        /// Years of Prior Adult Education Teaching Experience
        /// <para>
        /// The total number of years that a person has previously held a teaching position in one or more adult education programs.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19774">Years of Prior Adult Education Teaching Experience</a>
        /// </para>
        /// </summary>
        public System.Decimal? YearsOfPriorAeTeachingExperience { get; set; }

    }
}
