//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12Lea.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12Lea Interface
     /// </summary>
    public partial interface IK12Lea : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
        Guid? CharterSchoolIndicator { get; set; }

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
         RefLEAImprovementStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefLeaTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefPublicSchoolChoiceStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         SupervisoryUnionIdentificationNumber { get; set; }

    }
}
