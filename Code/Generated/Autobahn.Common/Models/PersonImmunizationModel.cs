//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonImmunizationModel.cs
//***************************************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonImmunization Model
     /// </summary>
    public partial class PersonImmunizationModel : AutobahnBase, Interfaces.IPersonImmunization
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
        public System.DateTime ImmunizationDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefImmunizationType"/> model
        /// </summary>
        public Guid RefImmunizationTypeId { get; set; }

    }
}
