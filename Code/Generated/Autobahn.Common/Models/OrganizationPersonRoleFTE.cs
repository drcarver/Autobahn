//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationPersonRoleFTE.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationPersonRoleFTE
     /// </summary>
    public partial class OrganizationPersonRoleFTE : IOrganizationPersonRoleFTE
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
        /// Defines the OrganizationPersonRoleFTE.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the OrganizationPersonRoleFTE.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
