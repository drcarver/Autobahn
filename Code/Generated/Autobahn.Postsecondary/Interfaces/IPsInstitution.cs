//***************************************************************************
//* DomainName: Postsecondary (PS) Interfaces (used by both models and View Models
//* FileName:   IPsInstitution.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The IPsInstitution Interface
     /// </summary>
    public partial interface IPsInstitution : IAutobahnBase
    {
        /// <summary>
        /// Institutionally Controlled Housing Status
        /// <para>
        /// An indication of whether an institution has any residence hall or housing facility located on- or off-campus that is owned or controlled by an institution and used by the institution in direct support of or in a manner related to, the institution's educational purposes.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19727">Institutionally Controlled Housing Status</a>
        /// </para>
        /// </summary>
        System.Boolean? InstitutionallyControlledHousingStatus { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAdministrativeFundingControl"/> model
        /// </summary>
        Guid? RefAdministrativeFundingControlId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAdmissionConsiderationLevel"/> model
        /// </summary>
        Guid? RefAdmissionConsiderationLevelId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAdmissionConsiderationType"/> model
        /// </summary>
        Guid? RefAdmissionConsiderationTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCarnegieBasicClassification"/> model
        /// </summary>
        Guid? RefCarnegieBasicClassificationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefControlOfInstitution"/> model
        /// </summary>
        Guid? RefControlOfInstitutionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIncreasedLearningTimeType"/> model
        /// </summary>
        Guid? RefIncreasedLearningTimeTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLevelOfInstitution"/> model
        /// </summary>
        Guid? RefLevelOfInstitutionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPredominantCalendarSystem"/> model
        /// </summary>
        Guid? RefPredominantCalendarSystemId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTenureSystem"/> model
        /// </summary>
        Guid? RefTenureSystemId { get; set; }

        /// <summary>
        /// Virtual Indicator
        /// <para>
        /// Indicates a school, institution, program, or course section focuses primarily on instruction in which students and teachers are separated by time and/or location and interact through the use of computers and/or telecommunications technologies.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20167">Virtual Indicator</a>
        /// </para>
        /// </summary>
        System.Boolean? VirtualIndicator { get; set; }

    }
}
