//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   IPsProgram.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The IPsProgram
     /// </summary>
    public partial interface IPsProgram : IAutobahnBase
    {
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

    }
}
