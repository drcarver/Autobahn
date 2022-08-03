//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   PsProgram.cs
//**********************************************************

using Autobahn.Postsecondary.Interfaces;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The PsProgram
     /// </summary>
    public partial class PsProgram : IPsProgram
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCipVersion"/> model
        /// </summary>
        public Guid? RefCipVersionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCipCode"/> model
        /// </summary>
        public Guid? RefCipCodeId { get; set; }

        /// <summary>
        /// Defines the PsProgram.ProgramLengthHours nullable property
        /// </summary>
        public System.Decimal? ProgramLengthHours { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProgramLengthHoursType"/> model
        /// </summary>
        public Guid? RefProgramLengthHoursTypeId { get; set; }

        /// <summary>
        /// Defines the PsProgram.NormalLengthTimeForCompletion non nullable property
        /// </summary>
        public System.String NormalLengthTimeForCompletion { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTimeForCompletionUnits"/> model
        /// </summary>
        public Guid? RefTimeForCompletionUnitsId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPSProgramLevel"/> model
        /// </summary>
        public Guid? RefPSProgramLevelId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDQPCategoriesOfLearning"/> model
        /// </summary>
        public Guid? RefDQPCategoriesOfLearningId { get; set; }

        /// <summary>
        /// Defines the PsProgram.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the PsProgram.RecordEndDateTime nullable property
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
