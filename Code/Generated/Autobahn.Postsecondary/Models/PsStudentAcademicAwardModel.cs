//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentAcademicAwardModel.cs
//* Name:       Academic Award Date
//* Definition: The year, month and day or year and month on which the academic award was conferred.
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The year, month and day or year and month on which the academic award was conferred.
     /// </summary>
    public partial class PsStudentAcademicAwardModel : AutobahnBase, Interfaces.IPsStudentAcademicAward
    {
        /// <summary>
        /// Academic Award Date
        /// <para>
        /// The year, month and day or year and month on which the academic award was conferred.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19001">Academic Award Date</a>
        /// </para>
        /// </summary>
        public System.String AcademicAwardDate { get; set; }

        /// <summary>
        /// Academic Award Title
        /// <para>
        /// The descriptive title for the academic award.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19003">Academic Award Title</a>
        /// </para>
        /// </summary>
        public System.String AcademicAwardTitle { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefAcademicAwardLevel"/> model
        /// </summary>
        public Guid? RefAcademicAwardLevelId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefAcademicAwardPrerequisiteType"/> model
        /// </summary>
        public Guid? RefAcademicAwardPrerequisiteTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefPESCAwardLevelType"/> model
        /// </summary>
        public Guid? RefPESCAwardLevelTypeId { get; set; }

        /// <summary>
        /// Academic Award Requirements URL
        /// <para>
        /// A URL to a page that describes the requirements for the credential.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20646">Academic Award Requirements URL</a>
        /// </para>
        /// </summary>
        public System.String RequirementsURL { get; set; }

    }
}
