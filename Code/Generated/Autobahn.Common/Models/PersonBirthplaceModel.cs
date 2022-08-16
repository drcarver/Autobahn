//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonBirthplaceModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonBirthplace Model
     /// </summary>
    public partial class PersonBirthplaceModel : AutobahnBase, Interfaces.IPersonBirthplace
    {
        /// <summary>
        /// 
        /// </summary>
        public  City { get; set; }

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
        public Guid? RefCountryId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefStateId { get; set; }

    }
}
