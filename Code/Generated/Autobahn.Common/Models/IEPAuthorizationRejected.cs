//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IEPAuthorizationRejected.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The IEPAuthorizationRejected
     /// </summary>
    public partial class IEPAuthorizationRejected : IIEPAuthorizationRejected
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="IEPAuthorization"/> model
        /// </summary>
        public Guid IEPAuthorizationId { get; set; }

        /// <summary>
        /// Defines the IEPAuthorizationRejected.PortionDescription non nullable property
        /// </summary>
        public System.String PortionDescription { get; set; }

        /// <summary>
        /// Defines the IEPAuthorizationRejected.PortionExplanation non nullable property
        /// </summary>
        public System.String PortionExplanation { get; set; }

        /// <summary>
        /// Defines the IEPAuthorizationRejected.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the IEPAuthorizationRejected.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
