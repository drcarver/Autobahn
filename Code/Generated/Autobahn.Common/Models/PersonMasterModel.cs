//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonMasterModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonMaster Model
     /// </summary>
    public partial class PersonMasterModel : AutobahnBase, Interfaces.IPersonMaster
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
