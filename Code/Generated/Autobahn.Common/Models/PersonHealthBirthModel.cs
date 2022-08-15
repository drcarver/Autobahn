//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonHealthBirthModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonHealthBirth Model
     /// </summary>
    public partial class PersonHealthBirthModel : AutobahnBase, Interfaces.IPersonHealthBirth
    {
        /// <summary>
        /// The weight of a child at birth in pounds and ounces.
        /// </summary>
        public System.String WeightAtBirth { get; set; }

    }
}
