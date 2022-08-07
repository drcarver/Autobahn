//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   PsProgramModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The PsProgram Model
     /// </summary>
    public partial class PsProgramModel : AutobahnBase, Interfaces.IPsProgramModel
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
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
