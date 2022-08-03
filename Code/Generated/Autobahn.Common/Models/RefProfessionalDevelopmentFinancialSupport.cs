//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefProfessionalDevelopmentFinancialSupport.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefProfessionalDevelopmentFinancialSupport
     /// </summary>
    public partial class RefProfessionalDevelopmentFinancialSupport : IRefProfessionalDevelopmentFinancialSupport
    {
        /// <summary>
        /// Defines the RefProfessionalDevelopmentFinancialSupport.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefProfessionalDevelopmentFinancialSupport.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefProfessionalDevelopmentFinancialSupport.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefProfessionalDevelopmentFinancialSupport.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefProfessionalDevelopmentFinancialSupport.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefProfessionalDevelopmentFinancialSupport.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
