//**********************************************************
//* DomainName: Common Models
//* FileName:   IncidentPersonModel.cs
//***************************************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The IncidentPerson Model
     /// </summary>
    public partial class IncidentPersonModel : AutobahnBase, Interfaces.IIncidentPerson
    {
        /// <summary>
        /// Incident Perpetrator Identifier
        /// <para>
        /// Identifies the perpetrator of the incident by use of a pre-existing unique identifier assigned to a student or staff member by a school or district.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20338">Incident Perpetrator Identifier</a>
        /// </para>
        /// </summary>
        public System.String Identifier { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IIncident"/> model
        /// </summary>
        public Guid IncidentId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIncidentPersonRoleType"/> model
        /// </summary>
        public Guid RefIncidentPersonRoleTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIncidentPersonType"/> model
        /// </summary>
        public Guid? RefIncidentPersonTypeId { get; set; }

    }
}
