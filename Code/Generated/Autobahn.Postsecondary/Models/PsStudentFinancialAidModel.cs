//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentFinancialAidModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The PsStudentFinancialAid Model
     /// </summary>
    public partial class PsStudentFinancialAidModel : AutobahnBase, Interfaces.IPsStudentFinancialAid
    {
        /// <summary>
        /// 
        /// </summary>
        public  FinancialAidApplicant { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  FinancialAidIncomeLevel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  FinancialNeed { get; set; }

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
        public  RefFinancialAidVeteransBenefitStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefFinancialAidVeteransBenefitTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefNeedDeterminationMethodId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? TitleIVParticipantAndRecipient { get; set; }

    }
}
