//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonProgramParticipationModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonProgramParticipation Model
     /// </summary>
    public partial class PersonProgramParticipationModel : AutobahnBase, Interfaces.IPersonProgramParticipation
    {
        /// <summary>
        /// 
        /// </summary>
        public  ParticipationStatus { get; set; }

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
        public Guid? RefParticipationTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefProgramEntryReasonId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefProgramExitReasonId { get; set; }

    }
}
