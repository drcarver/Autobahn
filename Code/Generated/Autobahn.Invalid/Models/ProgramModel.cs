//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   ProgramModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The Program Model
     /// </summary>
    public partial class ProgramModel : AutobahnBase, Interfaces.IProgram
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid? CreditsRequired { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

    }
}
