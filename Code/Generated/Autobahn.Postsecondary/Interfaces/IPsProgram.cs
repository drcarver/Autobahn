//***************************************************************************
//* DomainName: Postsecondary (PS) Interfaces (used by both models and View Models
//* FileName:   IPsProgram.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The IPsProgram Interface
     /// </summary>
    public partial interface IPsProgram : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         NormalLengthTimeForCompletion { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ProgramLengthHours { get; set; }

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
        Guid? RefCipCodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefCipVersionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefDQPCategoriesOfLearningId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefProgramLengthHoursTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefPSProgramLevelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefTimeForCompletionUnitsId { get; set; }

    }
}
