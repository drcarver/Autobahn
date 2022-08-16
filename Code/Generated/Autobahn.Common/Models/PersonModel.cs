//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The Person Model
     /// </summary>
    public partial class PersonModel : AutobahnBase, Interfaces.IPerson
    {
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
