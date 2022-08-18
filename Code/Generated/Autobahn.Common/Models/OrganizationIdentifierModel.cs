//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationIdentifierModel.cs
//***************************************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationIdentifier Model
     /// </summary>
    public partial class OrganizationIdentifierModel : AutobahnBase, Interfaces.IOrganizationIdentifier
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
        public System.String Identifier { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefOrganizationentificationSystem"/> model
        /// </summary>
        public Guid? RefOrganizationIdentificationSystemId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefOrganizationentifierType"/> model
        /// </summary>
        public Guid? RefOrganizationIdentifierTypeId { get; set; }

    }
}
