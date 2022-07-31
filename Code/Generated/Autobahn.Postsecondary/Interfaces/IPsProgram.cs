//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   IPsProgram.cs
//**********************************************************

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The IPsProgram
     /// </summary>
    public partial Interface IPsProgram
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="PsProgram"/> model
        /// </summary>
        Guid PsProgramId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCipVersion"/> model
        /// </summary>
        Guid? RefCipVersionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCipCode"/> model
        /// </summary>
        Guid? RefCipCodeId { get; set; }

        /// <summary>
        /// Defines the PsProgram.ProgramLengthHours nullable property
        /// </summary>
        System.Decimal? ProgramLengthHours { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProgramLengthHoursType"/> model
        /// </summary>
        Guid? RefProgramLengthHoursTypeId { get; set; }

        /// <summary>
        /// Defines the PsProgram.NormalLengthTimeForCompletion non nullable property
        /// </summary>
        System.String NormalLengthTimeForCompletion { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTimeForCompletionUnits"/> model
        /// </summary>
        Guid? RefTimeForCompletionUnitsId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPSProgramLevel"/> model
        /// </summary>
        Guid? RefPSProgramLevelId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDQPCategoriesOfLearning"/> model
        /// </summary>
        Guid? RefDQPCategoriesOfLearningId { get; set; }

        /// <summary>
        /// Defines the PsProgram.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the PsProgram.RecordEndDateTime nullable property
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
