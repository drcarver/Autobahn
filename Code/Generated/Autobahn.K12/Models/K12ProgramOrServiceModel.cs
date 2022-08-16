//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12ProgramOrServiceModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12ProgramOrService Model
     /// </summary>
    public partial class K12ProgramOrServiceModel : AutobahnBase, Interfaces.IK12ProgramOrService
    {
        /// <summary>
        /// 
        /// </summary>
        public  ProgramInMultiplePurposeFacility { get; set; }

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
        public  RefKindergartenDailyLengthId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefMepProjectTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RefMepSessionTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefPrekindergartenDailyLengthId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefProgramGiftedEligibilityId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefTitleIInstructionalServicesId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefTitleIProgramTypeId { get; set; }

    }
}
