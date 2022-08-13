//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   IActivity.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The IActivity Interface
     /// </summary>
    public partial interface IActivity : IAutobahnBase
    {
        /// <summary>
        /// A description of the events and procedures that take place under the purview of an organized activity, such as a co-curricular or extra-curricular activity that is offered at an education institution.
        /// </summary>
        System.String ActivityDescription { get; set; }

        /// <summary>
        /// A description of the events and procedures that take place under the purview of an organized activity, such as a co-curricular or extra-curricular activity that is offered at an education institution.
        /// </summary>
        Guid OrganizationId { get; set; }

    }
}