//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsInstitutionModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The PsInstitution Model
     /// </summary>
    public partial class PsInstitutionModel : AutobahnBase, Interfaces.IPsInstitution
    {
        /// <summary>
        /// The type of education institution as classified by its funding source.
        /// </summary>
        public System.Boolean? InstitutionallyControlledHousingStatus { get; set; }

        /// <summary>
        /// The type of education institution as classified by its funding source.
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// The type of education institution as classified by its funding source.
        /// </summary>
        public Guid? RefAdministrativeFundingControlId { get; set; }

        /// <summary>
        /// The type of education institution as classified by its funding source.
        /// </summary>
        public Guid? RefAdmissionConsiderationLevelId { get; set; }

        /// <summary>
        /// The type of education institution as classified by its funding source.
        /// </summary>
        public Guid? RefAdmissionConsiderationTypeId { get; set; }

        /// <summary>
        /// The type of education institution as classified by its funding source.
        /// </summary>
        public Guid? RefCarnegieBasicClassificationId { get; set; }

        /// <summary>
        /// The type of education institution as classified by its funding source.
        /// </summary>
        public Guid? RefControlOfInstitutionId { get; set; }

        /// <summary>
        /// The type of education institution as classified by its funding source.
        /// </summary>
        public Guid? RefIncreasedLearningTimeTypeId { get; set; }

        /// <summary>
        /// The type of education institution as classified by its funding source.
        /// </summary>
        public Guid? RefLevelOfInstitutionId { get; set; }

        /// <summary>
        /// The type of education institution as classified by its funding source.
        /// </summary>
        public Guid? RefPredominantCalendarSystemId { get; set; }

        /// <summary>
        /// The type of education institution as classified by its funding source.
        /// </summary>
        public Guid? RefTenureSystemId { get; set; }

        /// <summary>
        /// The type of education institution as classified by its funding source.
        /// </summary>
        public System.Boolean? VirtualIndicator { get; set; }

    }
}
