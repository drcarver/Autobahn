//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12ProgramOrService.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12ProgramOrService Interface
     /// </summary>
    public partial interface IK12ProgramOrService : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         ProgramInMultiplePurposeFacility { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefKindergartenDailyLengthId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefMepProjectTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? RefMepSessionTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefPrekindergartenDailyLengthId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefProgramGiftedEligibilityId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefTitleIInstructionalServicesId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefTitleIProgramTypeId { get; set; }

    }
}
