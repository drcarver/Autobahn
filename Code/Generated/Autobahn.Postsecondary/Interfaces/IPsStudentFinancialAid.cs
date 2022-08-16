//***************************************************************************
//* DomainName: Postsecondary (PS) Interfaces (used by both models and View Models
//* FileName:   IPsStudentFinancialAid.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The IPsStudentFinancialAid Interface
     /// </summary>
    public partial interface IPsStudentFinancialAid : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         FinancialAidApplicant { get; set; }

        /// <summary>
        /// 
        /// </summary>
         FinancialAidIncomeLevel { get; set; }

        /// <summary>
        /// 
        /// </summary>
         FinancialNeed { get; set; }

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
         RefFinancialAidVeteransBenefitStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefFinancialAidVeteransBenefitTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefNeedDeterminationMethodId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? TitleIVParticipantAndRecipient { get; set; }

    }
}
