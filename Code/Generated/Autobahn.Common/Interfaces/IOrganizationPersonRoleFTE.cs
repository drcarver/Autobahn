//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IOrganizationPersonRoleFTE.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationPersonRoleFTE Interface
     /// </summary>
    public partial interface IOrganizationPersonRoleFTE : IAutobahnBase
    {
        /// <summary>
        /// Full Time Equivalency
        /// <para>
        /// The time a person is enrolled, employed, involved, or participates in the organization, divided by the time the organization defines as full-time for that role.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20906">Full Time Equivalency</a>
        /// </para>
        /// </summary>
        System.Decimal FullTimeEquivalency { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

    }
}
