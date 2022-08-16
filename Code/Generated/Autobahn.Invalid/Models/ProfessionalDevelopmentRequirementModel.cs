//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   ProfessionalDevelopmentRequirementModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The ProfessionalDevelopmentRequirement Model
     /// </summary>
    public partial class ProfessionalDevelopmentRequirementModel : AutobahnBase, Interfaces.IProfessionalDevelopmentRequirement
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
        public Guid? RequiredTrainingClockHours { get; set; }

    }
}
