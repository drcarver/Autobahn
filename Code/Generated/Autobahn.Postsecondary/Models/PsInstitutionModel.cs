//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsInstitutionModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The PsInstitution Model
     /// </summary>
    public partial class PsInstitutionModel : AutobahnBase, Interfaces.IPsInstitution
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
        public System.Boolean? InstitutionallyControlledHousingStatus { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefAdministrativeFundingControl"/> model
        /// </summary>
        public Guid? RefAdministrativeFundingControlId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefAdmissionConsiderationLevel"/> model
        /// </summary>
        public Guid? RefAdmissionConsiderationLevelId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefAdmissionConsiderationType"/> model
        /// </summary>
        public Guid? RefAdmissionConsiderationTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefCarnegieBasicClassification"/> model
        /// </summary>
        public Guid? RefCarnegieBasicClassificationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefControlOfInstitution"/> model
        /// </summary>
        public Guid? RefControlOfInstitutionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefIncreasedLearningTimeType"/> model
        /// </summary>
        public Guid? RefIncreasedLearningTimeTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefLevelOfInstitution"/> model
        /// </summary>
        public Guid? RefLevelOfInstitutionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefPredominantCalendarSystem"/> model
        /// </summary>
        public Guid? RefPredominantCalendarSystemId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefTenureSystem"/> model
        /// </summary>
        public Guid? RefTenureSystemId { get; set; }

        /// <summary>
        /// Virtual Indicator
        /// <para>
        /// Indicates a school, institution, program, or course section focuses primarily on instruction in which students and teachers are separated by time and/or location and interact through the use of computers and/or telecommunications technologies.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20167">Virtual Indicator</a>
        /// </para>
        /// </summary>
        public System.Boolean? VirtualIndicator { get; set; }

    }
}
