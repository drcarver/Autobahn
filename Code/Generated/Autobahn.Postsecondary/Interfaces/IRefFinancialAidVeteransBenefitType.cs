//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   IRefFinancialAidVeteransBenefitType.cs
//**********************************************************

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The IRefFinancialAidVeteransBenefitType
     /// </summary>
    public partial interface IRefFinancialAidVeteransBenefitType
    {
        /// <summary>
        /// Defines the RefFinancialAidVeteransBenefitType.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefFinancialAidVeteransBenefitType.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefFinancialAidVeteransBenefitType.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefFinancialAidVeteransBenefitType.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefFinancialAidVeteransBenefitType.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefFinancialAidVeteransBenefitType.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
