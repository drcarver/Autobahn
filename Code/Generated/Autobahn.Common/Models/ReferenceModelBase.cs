//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ReferenceModelBase.cs
//**********************************************************

using Autobahn.Interfaces.Common;

namespace Autobahn.Common.Models
{
    /// <summary>
    /// The ReferenceModelBase
    /// </summary>
    public partial class ReferenceModelBase :  AutobahnBase, IReferenceModel
     {
        /// <summary>
        /// Defines the Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }
     }
}
