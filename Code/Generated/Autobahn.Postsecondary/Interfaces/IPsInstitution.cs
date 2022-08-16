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
        /// 
        /// </summary>
         InstitutionallyControlledHousingStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? RefAdministrativeFundingControlId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefAdmissionConsiderationLevelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefAdmissionConsiderationTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefCarnegieBasicClassificationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefControlOfInstitutionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefIncreasedLearningTimeTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefLevelOfInstitutionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefPredominantCalendarSystemId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefTenureSystemId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         VirtualIndicator { get; set; }

    }
}
