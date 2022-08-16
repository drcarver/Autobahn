//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonIdentifierModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonIdentifier Model
     /// </summary>
    public partial class PersonIdentifierModel : AutobahnBase, Interfaces.IPersonIdentifier
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid? Identifier { get; set; }

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
        public  RefPersonalInformationVerificationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefPersonIdentificationSystemId { get; set; }

    }
}
