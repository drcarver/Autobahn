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
        System.String WeightAtBirth { get; set; }

    }
}
