//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   ProgramParticipationWIOAModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The ProgramParticipationWIOA Model
     /// </summary>
    public partial class ProgramParticipationWIOAModel : AutobahnBase, Interfaces.IProgramParticipationWIOA
    {
        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  WIOACareerServices { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  WIOATrainingServices { get; set; }

    }
}
