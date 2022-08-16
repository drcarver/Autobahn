//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   ProgramParticipationTitleIModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The ProgramParticipationTitleI Model
     /// </summary>
    public partial class ProgramParticipationTitleIModel : AutobahnBase, Interfaces.IProgramParticipationTitleI
    {
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
        public Guid? RefTitleIIndicatorId { get; set; }

    }
}
