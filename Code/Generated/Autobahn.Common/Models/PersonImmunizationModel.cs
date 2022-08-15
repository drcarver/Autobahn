//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonImmunizationModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonImmunization Model
     /// </summary>
    public partial class PersonImmunizationModel : AutobahnBase, Interfaces.IPersonImmunization
    {
        /// <summary>
        /// The year, month and day of an immunization.
        /// </summary>
        public System.DateTime ImmunizationDate { get; set; }

    }
}
