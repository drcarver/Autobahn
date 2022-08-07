//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonHealthBirthModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonHealthBirth Model
     /// </summary>
    public partial class PersonHealthBirthModel : AutobahnBase, Interfaces.IPersonHealthBirthModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Defines the PersonHealthBirth.WeeksOfGestation nullable property
        /// </summary>
        public System.Int32? WeeksOfGestation { get; set; }

        /// <summary>
        /// Defines the PersonHealthBirth.MultipleBirthIndicator nullable property
        /// </summary>
        public System.Boolean? MultipleBirthIndicator { get; set; }

        /// <summary>
        /// Defines the PersonHealthBirth.WeightAtBirth non nullable property
        /// </summary>
        public System.String WeightAtBirth { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTrimesterWhenPrenatalCareBegan"/> model
        /// </summary>
        public Guid? RefTrimesterWhenPrenatalCareBeganId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
