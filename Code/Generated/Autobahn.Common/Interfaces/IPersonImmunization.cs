//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IPersonImmunization.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonImmunization Interface
     /// </summary>
    public partial interface IPersonImmunization : IAutobahnBase
    {
        /// <summary>
        /// The year, month and day of an immunization.
        /// </summary>
        System.DateTime ImmunizationDate { get; set; }

    }
}
