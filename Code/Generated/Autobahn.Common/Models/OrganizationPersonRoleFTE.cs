//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationPersonRoleFTE.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationPersonRoleFTE
     /// </summary>
    public partial class OrganizationPersonRoleFTE : AutobahnBase, Interfaces.IOrganizationPersonRoleFTE
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the OrganizationPersonRoleFTE.FullTimeEquivalency non nullable property
        /// </summary>
        public System.Decimal FullTimeEquivalency { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
