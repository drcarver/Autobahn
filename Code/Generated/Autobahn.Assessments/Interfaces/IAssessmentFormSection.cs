//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentFormSection.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessments.Interfaces
{
     /// <summary>
     /// The IAssessmentFormSection Interface
     /// </summary>
    public partial interface IAssessmentFormSection : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         AssessmentItemBankIdentifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
         AssessmentItemBankName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? GUID { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Identifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
         PublishedDate { get; set; }

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
         RefAssessmentFormSectionIdentificationSystemId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         SectionReentry { get; set; }

        /// <summary>
        /// 
        /// </summary>
         SectionSealed { get; set; }

        /// <summary>
        /// 
        /// </summary>
         SectionTimeLimit { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Version { get; set; }

    }
}
