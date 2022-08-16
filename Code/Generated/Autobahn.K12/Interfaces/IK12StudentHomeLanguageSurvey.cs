//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12StudentHomeLanguageSurvey.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12StudentHomeLanguageSurvey Interface
     /// </summary>
    public partial interface IK12StudentHomeLanguageSurvey : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         HomeLanguageSurveyAdministrationDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         HomeLanguageSurveyAdministrationIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? RecordStartDateTime { get; set; }

    }
}
