//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IK12Lea.cs
//**********************************************************

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12Lea
     /// </summary>
    public partial interface IK12Lea
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Defines the K12Lea.SupervisoryUnionIdentificationNumber non nullable property
        /// </summary>
        System.String SupervisoryUnionIdentificationNumber { get; set; }

        /// <summary>
        /// Defines the K12Lea.CharterSchoolIndicator nullable property
        /// </summary>
        System.Boolean? CharterSchoolIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLeaType"/> model
        /// </summary>
        Guid? RefLeaTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLeaImprovementStatus"/> model
        /// </summary>
        Guid? RefLeaImprovementStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPublicSchoolChoiceStatus"/> model
        /// </summary>
        Guid? RefPublicSchoolChoiceStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCharterLeaStatus"/> model
        /// </summary>
        Guid? RefCharterLeaStatusId { get; set; }

        /// <summary>
        /// Defines the K12Lea.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the K12Lea.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
