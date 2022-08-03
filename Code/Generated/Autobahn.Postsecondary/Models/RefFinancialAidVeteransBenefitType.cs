//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefFinancialAidVeteransBenefitType.cs
//**********************************************************

using Autobahn.Postsecondary.Interfaces;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The RefFinancialAidVeteransBenefitType
     /// </summary>
    public partial class RefFinancialAidVeteransBenefitType : IRefFinancialAidVeteransBenefitType
    {
        /// <summary>
        /// Defines the RefFinancialAidVeteransBenefitType.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefFinancialAidVeteransBenefitType.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefFinancialAidVeteransBenefitType.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefFinancialAidVeteransBenefitType.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefFinancialAidVeteransBenefitType.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefFinancialAidVeteransBenefitType.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
