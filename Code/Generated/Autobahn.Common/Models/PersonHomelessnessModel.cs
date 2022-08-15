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
        /// The primary nighttime residence of the person at the time the person was identified as homeless.
        /// </summary>
        public Guid RefHomelessNighttimeResidenceId { get; set; }

    }
}
