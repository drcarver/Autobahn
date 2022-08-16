//***************************************************************************
//* DomainName: Career and Technical Education (CTE) Interfaces (used by both models and View Models
//* FileName:   IProgramParticipationCte.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.CTE.Interfaces
{
     /// <summary>
     /// The IProgramParticipationCte Interface
     /// </summary>
    public partial interface IProgramParticipationCte : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         CareerPathwaysProgramParticipationExitDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         CareerPathwaysProgramParticipationStartDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? CteCompleter { get; set; }

        /// <summary>
        /// 
        /// </summary>
         CteConcentrator { get; set; }

        /// <summary>
        /// 
        /// </summary>
         CteNonTraditionalCompletion { get; set; }

        /// <summary>
        /// 
        /// </summary>
         CteParticipant { get; set; }

        /// <summary>
        /// 
        /// </summary>
         DisplacedHomemakerIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
         OutOfWorkforceIndicator { get; set; }

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
         RefNonTraditionalGenderStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefWorkbasedLearningOpportunityTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         SingleParentOrSinglePregnantWoman { get; set; }

    }
}
