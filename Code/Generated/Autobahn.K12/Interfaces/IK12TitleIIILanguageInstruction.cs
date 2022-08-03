//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IK12TitleIIILanguageInstruction.cs
//**********************************************************

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12TitleIIILanguageInstruction
     /// </summary>
    public partial interface IK12TitleIIILanguageInstruction
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefTitleIIILanguageInstructionProgramType"/> model
        /// </summary>
        Guid RefTitleIIILanguageInstructionProgramTypeId { get; set; }

        /// <summary>
        /// Defines the K12TitleIIILanguageInstruction.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the K12TitleIIILanguageInstruction.RecordEndDateTime nullable property
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
