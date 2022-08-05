//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IOrganizationPersonRoleFTE.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationPersonRoleFTE
     /// </summary>
    public partial interface IOrganizationPersonRoleFTE : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the OrganizationPersonRoleFTE.FullTimeEquivalency non nullable property
        /// </summary>
        System.Decimal FullTimeEquivalency { get; set; }

    }
}
