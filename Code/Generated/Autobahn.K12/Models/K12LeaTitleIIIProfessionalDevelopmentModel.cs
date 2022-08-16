//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12LeaTitleIIIProfessionalDevelopmentModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12LeaTitleIIIProfessionalDevelopment Model
     /// </summary>
    public partial class K12LeaTitleIIIProfessionalDevelopmentModel : AutobahnBase, Interfaces.IK12LeaTitleIIIProfessionalDevelopment
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
        public Guid? RefTitleIIIProfessionalDevelopmentTypeId { get; set; }

    }
}
