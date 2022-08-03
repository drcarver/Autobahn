//**********************************************************
//* DomainName: Autobahn.Reference
//* FileName:   RefCharterSchoolManagementOrganizationType.cs
//**********************************************************

using Autobahn.Reference.Interfaces;

namespace Autobahn.Reference.Models
{
     /// <summary>
     /// The RefCharterSchoolManagementOrganizationType
     /// </summary>
    public partial class RefCharterSchoolManagementOrganizationType : IRefCharterSchoolManagementOrganizationType
    {
        /// <summary>
        /// Defines the RefCharterSchoolManagementOrganizationType.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefCharterSchoolManagementOrganizationType.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefCharterSchoolManagementOrganizationType.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefCharterSchoolManagementOrganizationType.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefCharterSchoolManagementOrganizationType.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefCharterSchoolManagementOrganizationType.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
