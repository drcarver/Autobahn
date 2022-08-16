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
        /// 
        /// </summary>
        public  NormalLengthTimeForCompletion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ProgramLengthHours { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RefCipCodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefCipVersionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefDQPCategoriesOfLearningId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefProgramLengthHoursTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefPSProgramLevelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefTimeForCompletionUnitsId { get; set; }

    }
}
