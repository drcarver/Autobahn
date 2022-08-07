//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonImmunizationModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonImmunization Model
     /// </summary>
    public partial class PersonImmunizationModel : AutobahnBase, Interfaces.IPersonImmunizationModel
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
