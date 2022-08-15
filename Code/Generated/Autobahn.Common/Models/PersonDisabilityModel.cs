//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonDisabilityModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonDisability Model
     /// </summary>
    public partial class PersonDisabilityModel : AutobahnBase, Interfaces.IPersonDisability
    {
        /// <summary>
        /// The major or overriding disability condition that best describes a person's impairment.
        /// </summary>
        public Guid? PrimaryDisabilityTypeId { get; set; }

    }
}
