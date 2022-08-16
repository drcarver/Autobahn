//**********************************************************
//* DomainName: Learning Resources
//* FileName:   LearningResourceModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.LearningResources.Models
{
     /// <summary>
     /// The LearningResource Model
     /// </summary>
    public partial class LearningResourceModel : AutobahnBase, Interfaces.ILearningResource
    {
        /// <summary>
        /// 
        /// </summary>
        public  AdaptedFromURL { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  AssistiveTechnologiesCompatibleInd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  BasedOnUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ConceptKeyword { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  CopyrightHolderName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  CopyrightYear { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Creator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  DateCreated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  LearningResourceAuthorEmail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  LearningResourceAuthorURL { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  LearningResourceDateModified { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  LearningResourceLicenseURL { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  LearningResourcePublisherEmail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  LearningResourcePublisherURL { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  PeerRatingSampleSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  PublishedDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  PublisherName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefLanguageId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefLearningResourceAccessAPITypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefLearningResourceAccessHazardTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefLearningResourceAccessModeTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefLearningResourceAccessRightsUrlId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefLearningResourceAuthorTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefLearningResourceBookFormatTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefLearningResourceControlFlexibilityTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefLearningResourceDigitalMediaSubTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefLearningResourceDigitalMediaTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefLearningResourceEducationalUseId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefLearningResourceIntendedEndUserRoleId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefLearningResourceInteractionModeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefLearningResourceInteractivityTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefLearningResourceTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  SubjectCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  SubjectCodeSystem { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  SubjectName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  TextComplexitySystem { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  TextComplexityValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  TimeRequired { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  TypicalAgeRangeMaximum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  TypicalAgeRangeMinimum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Version { get; set; }

    }
}
