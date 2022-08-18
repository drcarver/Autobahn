//***************************************************************************
//* DomainName: Postsecondary (PS) Interfaces (used by both models and View Models
//* FileName:   IPsStudentAcademicAward.cs
//* Name:       Academic Award Date
//* Definition: 
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// 
     /// </summary>
    public partial interface IPsStudentAcademicAward : IAutobahnBase
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
        System.String AcademicAwardDate { get; set; }

        /// <summary>
        /// Academic Award Title
        /// <para>
        /// The descriptive title for the academic award.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19003">Academic Award Title</a>
        /// </para>
        /// </summary>
        System.String AcademicAwardTitle { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAcademicAwardLevel"/> model
        /// </summary>
        Guid? RefAcademicAwardLevelId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAcademicAwardPrerequisiteType"/> model
        /// </summary>
        Guid? RefAcademicAwardPrerequisiteTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPESCAwardLevelType"/> model
        /// </summary>
        Guid? RefPESCAwardLevelTypeId { get; set; }

        /// <summary>
        /// Academic Award Requirements URL
        /// <para>
        /// A URL to a page that describes the requirements for the credential.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20646">Academic Award Requirements URL</a>
        /// </para>
        /// </summary>
        System.String RequirementsURL { get; set; }

    }
}
