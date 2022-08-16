//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   ProfessionalDevelopmentSessionInstructorModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The ProfessionalDevelopmentSessionInstructor Model
     /// </summary>
    public partial class ProfessionalDevelopmentSessionInstructorModel : AutobahnBase, Interfaces.IProfessionalDevelopmentSessionInstructor
    {
        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RecordStartDateTime { get; set; }

    }
}
