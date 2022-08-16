//**********************************************************
//* DomainName: Career and Technical Education (CTE)
//* FileName:   ProgramParticipationCteModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.CTE.Models
{
     /// <summary>
     /// The ProgramParticipationCte Model
     /// </summary>
    public partial class ProgramParticipationCteModel : AutobahnBase, Interfaces.IProgramParticipationCte
    {
        /// <summary>
        /// 
        /// </summary>
        public  CareerPathwaysProgramParticipationExitDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  CareerPathwaysProgramParticipationStartDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? CteCompleter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  CteConcentrator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  CteNonTraditionalCompletion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  CteParticipant { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  DisplacedHomemakerIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  OutOfWorkforceIndicator { get; set; }

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
        public  RefNonTraditionalGenderStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefWorkbasedLearningOpportunityTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  SingleParentOrSinglePregnantWoman { get; set; }

    }
}
