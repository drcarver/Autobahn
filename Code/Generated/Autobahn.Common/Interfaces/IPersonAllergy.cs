//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IPersonAllergy.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonAllergy Interface
     /// </summary>
    public partial interface IPersonAllergy : IAutobahnBase
    {
        /// <summary>
        /// Describes symptoms know to be associated with a person's reaction to an allergen.
        /// </summary>
        System.String ReactionDescription { get; set; }

    }
}
