//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IK12ProgramOrService.cs
//**********************************************************

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12ProgramOrService
     /// </summary>
    public partial interface IK12ProgramOrService
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Defines the K12ProgramOrService.ProgramInMultiplePurposeFacility nullable property
        /// </summary>
        System.Boolean? ProgramInMultiplePurposeFacility { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPrekindergartenDailyLength"/> model
        /// </summary>
        Guid? RefPrekindergartenDailyLengthId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefKindergartenDailyLength"/> model
        /// </summary>
        Guid? RefKindergartenDailyLengthId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProgramGiftedEligibility"/> model
        /// </summary>
        Guid? RefProgramGiftedEligibilityId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMepSessionType"/> model
        /// </summary>
        Guid? RefMepSessionTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMepProjectType"/> model
        /// </summary>
        Guid? RefMepProjectTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTitleIInstructionalServices"/> model
        /// </summary>
        Guid? RefTitleIInstructionalServicesId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTitleIProgramType"/> model
        /// </summary>
        Guid? RefTitleIProgramTypeId { get; set; }

        /// <summary>
        /// Defines the K12ProgramOrService.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the K12ProgramOrService.RecordEndDateTime nullable property
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
