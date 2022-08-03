//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefProfessionalDevelopmentFinancialSupport.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IRefProfessionalDevelopmentFinancialSupport
     /// </summary>
    public partial interface IRefProfessionalDevelopmentFinancialSupport
    {
        /// <summary>
        /// Defines the RefProfessionalDevelopmentFinancialSupport.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefProfessionalDevelopmentFinancialSupport.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefProfessionalDevelopmentFinancialSupport.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefProfessionalDevelopmentFinancialSupport.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefProfessionalDevelopmentFinancialSupport.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefProfessionalDevelopmentFinancialSupport.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
