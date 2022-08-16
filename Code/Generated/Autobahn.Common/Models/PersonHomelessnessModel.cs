//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonHomelessnessModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonHomelessness Model
     /// </summary>
    public partial class PersonHomelessnessModel : AutobahnBase, Interfaces.IPersonHomelessness
    {
        /// <summary>
        /// 
        /// </summary>
        public  HomelessnessStatus { get; set; }

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
        public Guid? RefHomelessNighttimeResidenceId { get; set; }

    }
}
