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
        /// The type of education institution as classified by its funding source.
        /// </summary>
        System.Boolean? InstitutionallyControlledHousingStatus { get; set; }

        /// <summary>
        /// The type of education institution as classified by its funding source.
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// The type of education institution as classified by its funding source.
        /// </summary>
        Guid? RefAdministrativeFundingControlId { get; set; }

        /// <summary>
        /// The type of education institution as classified by its funding source.
        /// </summary>
        Guid? RefAdmissionConsiderationLevelId { get; set; }

        /// <summary>
        /// The type of education institution as classified by its funding source.
        /// </summary>
        Guid? RefAdmissionConsiderationTypeId { get; set; }

        /// <summary>
        /// The type of education institution as classified by its funding source.
        /// </summary>
        Guid? RefCarnegieBasicClassificationId { get; set; }

        /// <summary>
        /// The type of education institution as classified by its funding source.
        /// </summary>
        Guid? RefControlOfInstitutionId { get; set; }

        /// <summary>
        /// The type of education institution as classified by its funding source.
        /// </summary>
        Guid? RefIncreasedLearningTimeTypeId { get; set; }

        /// <summary>
        /// The type of education institution as classified by its funding source.
        /// </summary>
        Guid? RefLevelOfInstitutionId { get; set; }

        /// <summary>
        /// The type of education institution as classified by its funding source.
        /// </summary>
        Guid? RefPredominantCalendarSystemId { get; set; }

        /// <summary>
        /// The type of education institution as classified by its funding source.
        /// </summary>
        Guid? RefTenureSystemId { get; set; }

        /// <summary>
        /// The type of education institution as classified by its funding source.
        /// </summary>
        System.Boolean? VirtualIndicator { get; set; }

    }
}
