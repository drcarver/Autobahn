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
        /// Immunization Date
        /// <para>
        /// The year, month and day of an immunization.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19306">Immunization Date</a>
        /// </para>
        /// </summary>
        System.DateTime ImmunizationDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefImmunizationType"/> model
        /// </summary>
        Guid RefImmunizationTypeId { get; set; }

    }
}
