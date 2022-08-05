//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IPersonHealthBirth.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonHealthBirth
     /// </summary>
    public partial interface IPersonHealthBirth : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// Defines the PersonHealthBirth.WeeksOfGestation nullable property
        /// </summary>
        System.Int32? WeeksOfGestation { get; set; }

        /// <summary>
        /// Defines the PersonHealthBirth.MultipleBirthIndicator nullable property
        /// </summary>
        System.Boolean? MultipleBirthIndicator { get; set; }

        /// <summary>
        /// Defines the PersonHealthBirth.WeightAtBirth non nullable property
        /// </summary>
        System.String WeightAtBirth { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTrimesterWhenPrenatalCareBegan"/> model
        /// </summary>
        Guid? RefTrimesterWhenPrenatalCareBeganId { get; set; }

    }
}
