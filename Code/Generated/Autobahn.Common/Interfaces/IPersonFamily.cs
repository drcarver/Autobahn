//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IPersonFamily.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonFamily Interface
     /// </summary>
    public partial interface IPersonFamily : IAutobahnBase
    {
        /// <summary>
        /// The extent of formal instruction a person has received (e.g., the highest grade in school completed or its equivalent or the highest degree received).
        /// </summary>
        Guid? RefHighestEducationLevelCompletedId { get; set; }

    }
}
