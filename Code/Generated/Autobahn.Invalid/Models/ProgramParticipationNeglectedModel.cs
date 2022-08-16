//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   ProgramParticipationNeglectedModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The ProgramParticipationNeglected Model
     /// </summary>
    public partial class ProgramParticipationNeglectedModel : AutobahnBase, Interfaces.IProgramParticipationNeglected
    {
        /// <summary>
        /// 
        /// </summary>
        public  AchievementIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ObtainedEmployment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  OutcomeIndicator { get; set; }

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
        public Guid? RefNeglectedProgramTypeId { get; set; }

    }
}
