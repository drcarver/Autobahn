//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   RequiredImmunizationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The RequiredImmunization Model
     /// </summary>
    public partial class RequiredImmunizationModel : AutobahnBase, Interfaces.IRequiredImmunization
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
        public Guid? RefImmunizationTypeId { get; set; }

    }
}
