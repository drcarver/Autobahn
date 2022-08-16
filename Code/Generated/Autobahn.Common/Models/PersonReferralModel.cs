//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonReferralModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonReferral Model
     /// </summary>
    public partial class PersonReferralModel : AutobahnBase, Interfaces.IPersonReferral
    {
        /// <summary>
        /// 
        /// </summary>
        public  Reason { get; set; }

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
        public Guid? ReferralDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ReferralTypeReceived { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ReferredTo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefReferralOutcomeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Source { get; set; }

    }
}
