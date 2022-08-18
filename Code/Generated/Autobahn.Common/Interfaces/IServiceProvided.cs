//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IServiceProvided.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IServiceProvided Interface
     /// </summary>
    public partial interface IServiceProvided : IAutobahnBase
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
        Guid? RefServicesId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefStudentSupportServiceType"/> model
        /// </summary>
        Guid? RefStudentSupportServiceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IServicesReceived"/> model
        /// </summary>
        Guid ServicesReceivedId { get; set; }

    }
}
