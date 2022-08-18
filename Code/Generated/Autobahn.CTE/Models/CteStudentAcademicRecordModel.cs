//**********************************************************
//* DomainName: Career and Technical Education (CTE)
//* FileName:   CteStudentAcademicRecordModel.cs
//* Name:       Credits Attempted Cumulative
//* Definition: The cumulative number of credits a person attempts to earn by taking courses during their enrollment in their current education institution as well as those credits transferred from an education institution in which the person had been previously enrolled.
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.CTE.Models
{
     /// <summary>
     /// The cumulative number of credits a person attempts to earn by taking courses during their enrollment in their current education institution as well as those credits transferred from an education institution in which the person had been previously enrolled.
     /// </summary>
    public partial class CteStudentAcademicRecordModel : AutobahnBase, Interfaces.ICteStudentAcademicRecord
    {
        /// <summary>
        /// Credits Attempted Cumulative
        /// <para>
        /// The cumulative number of credits a person attempts to earn by taking courses during their enrollment in their current education institution as well as those credits transferred from an education institution in which the person had been previously enrolled.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19073">Credits Attempted Cumulative</a>
        /// </para>
        /// </summary>
        public System.Decimal? CreditsAttemptedCumulative { get; set; }

        /// <summary>
        /// Credits Earned Cumulative
        /// <para>
        /// The cumulative number of credits a person earns by completing courses or examinations during their enrollment in the current education institution as well as those credits transferred from an education institution in which the person had been previously enrolled.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19074">Credits Earned Cumulative</a>
        /// </para>
        /// </summary>
        public System.Decimal? CreditsEarnedCumulative { get; set; }

        /// <summary>
        /// Diploma or Credential Award Date
        /// <para>
        /// The month and year on which the diploma/credential is awarded to a student in recognition of his/her completion of the curricular requirements.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19081">Diploma or Credential Award Date</a>
        /// </para>
        /// </summary>
        public System.String DiplomaOrCredentialAwardDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProfessionalTechnicalCredentialType"/> model
        /// </summary>
        public Guid? RefProfessionalTechnicalCredentialTypeId { get; set; }

    }
}
