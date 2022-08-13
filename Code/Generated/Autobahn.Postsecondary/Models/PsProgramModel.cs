//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsProgramModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The PsProgram Model
     /// </summary>
    public partial class PsProgramModel : AutobahnBase, Interfaces.IPsProgram
    {
        /// <summary>
        /// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
        /// </summary>
        public System.String NormalLengthTimeForCompletion { get; set; }

        /// <summary>
        /// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
        /// </summary>
        public System.Decimal? ProgramLengthHours { get; set; }

        /// <summary>
        /// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
        /// </summary>
        public Guid? RefCipCodeId { get; set; }

        /// <summary>
        /// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
        /// </summary>
        public Guid? RefCipVersionId { get; set; }

        /// <summary>
        /// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
        /// </summary>
        public Guid? RefDQPCategoriesOfLearningId { get; set; }

        /// <summary>
        /// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
        /// </summary>
        public Guid? RefProgramLengthHoursTypeId { get; set; }

        /// <summary>
        /// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
        /// </summary>
        public Guid? RefPSProgramLevelId { get; set; }

        /// <summary>
        /// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
        /// </summary>
        public Guid? RefTimeForCompletionUnitsId { get; set; }

    }
}
