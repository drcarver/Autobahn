//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IEPAuthorizationRejected.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The IEPAuthorizationRejected
     /// </summary>
    public partial class IEPAuthorizationRejected : AutobahnBase, Interfaces.IIEPAuthorizationRejected
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
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
