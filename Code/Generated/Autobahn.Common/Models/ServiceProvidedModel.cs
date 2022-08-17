//**********************************************************
//* DomainName: Common Models
//* FileName:   ServiceProvidedModel.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The ServiceProvided Model
     /// </summary>
    public partial class ServiceProvidedModel : AutobahnBase, Interfaces.IServiceProvided
    {
        /// <summary>
        /// Early Childhood Services Received
        /// <para>
        /// The types of service that adapts the curriculum, materials, or instruction for students identified as needing additional resources.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19321">Early Childhood Services Received</a>
        /// </para>
        /// </summary>
        public Guid? RefServicesId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefStudentSupportServiceType"/> model
        /// </summary>
        public Guid? RefStudentSupportServiceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IServicesReceived"/> model
        /// </summary>
        public Guid ServicesReceivedId { get; set; }

    }
}
