//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IOrganizationPersonRoleFTEModel.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationPersonRoleFTEModel Interface
     /// </summary>
    public partial interface IOrganizationPersonRoleFTEModel : IAutobahnBase
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
