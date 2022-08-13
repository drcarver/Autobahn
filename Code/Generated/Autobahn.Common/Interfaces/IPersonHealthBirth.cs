//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IPersonHealthBirth.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonHealthBirth Interface
     /// </summary>
    public partial interface IPersonHealthBirth : IAutobahnBase
    {
        /// <summary>
        /// The weight of a child at birth in pounds and ounces.
        /// </summary>
        System.Boolean? MultipleBirthIndicator { get; set; }

        /// <summary>
        /// The weight of a child at birth in pounds and ounces.
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// The weight of a child at birth in pounds and ounces.
        /// </summary>
        Guid? RefTrimesterWhenPrenatalCareBeganId { get; set; }

        /// <summary>
        /// The weight of a child at birth in pounds and ounces.
        /// </summary>
        System.Int32? WeeksOfGestation { get; set; }

        /// <summary>
        /// The weight of a child at birth in pounds and ounces.
        /// </summary>
        System.String WeightAtBirth { get; set; }

    }
}
