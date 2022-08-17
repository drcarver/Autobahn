//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IOrganizationIdentifier.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationIdentifier Interface
     /// </summary>
    public partial interface IOrganizationIdentifier : IAutobahnBase
    {
        /// <summary>
        /// Course Identifier
        /// <para>
        /// The actual code that identifies the organization of subject matter and related learning experiences provided for the instruction of students.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19055">Course Identifier</a>
        /// </para>
        /// </summary>
        System.String Identifier { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefOrganizationentificationSystem"/> model
        /// </summary>
        Guid? RefOrganizationIdentificationSystemId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefOrganizationentifierType"/> model
        /// </summary>
        Guid? RefOrganizationIdentifierTypeId { get; set; }

    }
}
