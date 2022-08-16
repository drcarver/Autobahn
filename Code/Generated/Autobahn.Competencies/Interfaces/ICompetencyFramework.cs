//***************************************************************************
//* DomainName: Competencies Interfaces (used by both models and View Models
//* FileName:   ICompetencyFramework.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Competencies.Interfaces
{
     /// <summary>
     /// The ICompetencyFramework Interface
     /// </summary>
    public partial interface ICompetencyFramework : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         CompetencyFrameworkPublicationDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         CompetencyFrameworkSourceUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Creator { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Jurisdiction { get; set; }

        /// <summary>
        /// 
        /// </summary>
         License { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Publisher { get; set; }

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
         RefCompetencyFrameworkPublicationStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefLanguageId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Rights { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RightsHolder { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Subject { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? URI { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ValidEndDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ValidStartDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Version { get; set; }

    }
}
