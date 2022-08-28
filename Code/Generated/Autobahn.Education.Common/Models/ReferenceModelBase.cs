//**********************************************************
//* DomainName: Autobahn.Education.Common
//* FileName:   ReferenceModelBase.cs
//**********************************************************

using Autobahn.Education.Interfaces.Common;

namespace Autobahn.Education.Common.Models
{
    /// <summary>
    /// The ReferenceModelBase
    /// </summary>
    public partial class ReferenceModelBase : IReferenceModel
    {
        /// <summary>
        /// Defines the Description non nullable property
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Defines the Code non nullable property
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Defines the Definition non nullable property
        /// </summary>
        public string Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the SortOrder nullable property
        /// </summary>
        public decimal? SortOrder { get; set; }
    }
}
