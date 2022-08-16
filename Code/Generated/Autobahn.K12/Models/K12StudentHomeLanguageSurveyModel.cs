//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentHomeLanguageSurveyModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12StudentHomeLanguageSurvey Model
     /// </summary>
    public partial class K12StudentHomeLanguageSurveyModel : AutobahnBase, Interfaces.IK12StudentHomeLanguageSurvey
    {
        /// <summary>
        /// 
        /// </summary>
        public  HomeLanguageSurveyAdministrationDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  HomeLanguageSurveyAdministrationIndicator { get; set; }

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
