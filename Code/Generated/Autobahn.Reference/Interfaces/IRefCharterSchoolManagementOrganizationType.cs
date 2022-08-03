//**********************************************************
//* DomainName: Autobahn.Reference
//* FileName:   IRefCharterSchoolManagementOrganizationType.cs
//**********************************************************

namespace Autobahn.Reference.Interfaces
{
     /// <summary>
     /// The IRefCharterSchoolManagementOrganizationType
     /// </summary>
    public partial interface IRefCharterSchoolManagementOrganizationType
    {
        /// <summary>
        /// Defines the RefCharterSchoolManagementOrganizationType.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefCharterSchoolManagementOrganizationType.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefCharterSchoolManagementOrganizationType.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefCharterSchoolManagementOrganizationType.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefCharterSchoolManagementOrganizationType.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefCharterSchoolManagementOrganizationType.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
