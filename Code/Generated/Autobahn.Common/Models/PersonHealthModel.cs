//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonHealthModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonHealth Model
     /// </summary>
    public partial class PersonHealthModel : AutobahnBase, Interfaces.IPersonHealth
    {
        /// <summary>
        /// Status of an examination used to measure a person's ability to see.
        /// </summary>
        public Guid? RefVisionScreeningStatusId { get; set; }

    }
}
