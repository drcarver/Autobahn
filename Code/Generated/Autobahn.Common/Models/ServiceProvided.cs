//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ServiceProvided.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The ServiceProvided
     /// </summary>
    public partial class ServiceProvided : AutobahnBase, Interfaces.IServiceProvided
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="ServicesReceived"/> model
        /// </summary>
        public Guid ServicesReceivedId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefServices"/> model
        /// </summary>
        public Guid? RefServicesId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefStudentSupportServiceType"/> model
        /// </summary>
        public Guid? RefStudentSupportServiceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
