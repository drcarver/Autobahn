//***************************************************************************
//* DomainName: Learning Resources Interfaces (used by both models and View Models
//* FileName:   ILearningResource.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.LearningResources.Interfaces
{
     /// <summary>
     /// The ILearningResource Interface
     /// </summary>
    public partial interface ILearningResource : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         AdaptedFromURL { get; set; }

        /// <summary>
        /// 
        /// </summary>
         AssistiveTechnologiesCompatibleInd { get; set; }

        /// <summary>
        /// 
        /// </summary>
         BasedOnUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ConceptKeyword { get; set; }

        /// <summary>
        /// 
        /// </summary>
         CopyrightHolderName { get; set; }

        /// <summary>
        /// 
        /// </summary>
         CopyrightYear { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Creator { get; set; }

        /// <summary>
        /// 
        /// </summary>
         DateCreated { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
         LearningResourceAuthorEmail { get; set; }

        /// <summary>
        /// 
        /// </summary>
         LearningResourceAuthorURL { get; set; }

        /// <summary>
        /// 
        /// </summary>
         LearningResourceDateModified { get; set; }

        /// <summary>
        /// 
        /// </summary>
         LearningResourceLicenseURL { get; set; }

        /// <summary>
        /// 
        /// </summary>
         LearningResourcePublisherEmail { get; set; }

        /// <summary>
        /// 
        /// </summary>
         LearningResourcePublisherURL { get; set; }

        /// <summary>
        /// 
        /// </summary>
         PeerRatingSampleSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
         PublishedDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         PublisherName { get; set; }

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
         RefLanguageId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefLearningResourceAccessAPITypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefLearningResourceAccessHazardTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefLearningResourceAccessModeTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefLearningResourceAccessRightsUrlId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefLearningResourceAuthorTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefLearningResourceBookFormatTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefLearningResourceControlFlexibilityTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefLearningResourceDigitalMediaSubTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefLearningResourceDigitalMediaTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefLearningResourceEducationalUseId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefLearningResourceIntendedEndUserRoleId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefLearningResourceInteractionModeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefLearningResourceInteractivityTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefLearningResourceTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         SubjectCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
         SubjectCodeSystem { get; set; }

        /// <summary>
        /// 
        /// </summary>
         SubjectName { get; set; }

        /// <summary>
        /// 
        /// </summary>
         TextComplexitySystem { get; set; }

        /// <summary>
        /// 
        /// </summary>
         TextComplexityValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
         TimeRequired { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
         TypicalAgeRangeMaximum { get; set; }

        /// <summary>
        /// 
        /// </summary>
         TypicalAgeRangeMinimum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Version { get; set; }

    }
}
