//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IActivity.cs
//* Name:       Activity Description
//* Definition: 
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// 
     /// </summary>
    public partial interface IActivity : IAutobahnBase
    {
        /// <summary>
        /// Activity Description
        /// <para>
        /// A description of the events and procedures that take place under the purview of an organized activity, such as a co-curricular or extra-curricular activity that is offered at an education institution.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20505">Activity Description</a>
        /// </para>
        /// </summary>
        System.String ActivityDescription { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

    }
}
