//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IOrganizationPersonRoleFte.cs
//***************************************************************************

namespace Autobahn.Interfaces.Common
{
     /// <summary>
     /// The IOrganizationPersonRoleFte Interface
     /// </summary>
    public partial interface IOrganizationPersonRoleFte : IAutobahnBase
    {
        System.Decimal FullTimeEquivalency { get; set; }

        System.Int32 OrganizationPersonRoleFteid { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

    }
}
