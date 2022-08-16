//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonLanguageModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonLanguage Model
     /// </summary>
    public partial class PersonLanguageModel : AutobahnBase, Interfaces.IPersonLanguage
    {
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
        public  RefLanguageId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RefLanguageUseTypeId { get; set; }

    }
}
