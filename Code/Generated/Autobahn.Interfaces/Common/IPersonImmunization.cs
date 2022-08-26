//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IPersonImmunization.cs
//***************************************************************************

namespace Autobahn.Interfaces.Common
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
        /// Immunization Type
        /// <para>
        /// An indication of the type of immunization that an individual has satisfactorily received. (Note: The International Classification of Diseases (ICD) is maintained by the World Health Organization. The ICD is revised periodically to incorporate changes in the medical field, the most updated and detailed list of International Statistical Classification of Diseases and Related Health Problems can be found at http://www.who.int/classifications/apps/icd/icd10online).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20214">Immunization Type</a>
        /// </para>
        /// </summary>
        Guid RefImmunizationTypeId { get; set; }

    }
}
