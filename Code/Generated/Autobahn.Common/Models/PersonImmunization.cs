//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonImmunization.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonImmunization
     /// </summary>
    public partial class PersonImmunization : AutobahnBase, Interfaces.IPersonImmunization
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Defines the PersonImmunization.ImmunizationDate non nullable property
        /// </summary>
        public System.DateTime ImmunizationDate { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefImmunizationType"/> model
        /// </summary>
        public Guid RefImmunizationTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
