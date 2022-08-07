//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RequiredImmunizationModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RequiredImmunization Model
     /// </summary>
    public partial class RequiredImmunizationModel : AutobahnBase, Interfaces.IRequiredImmunizationModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

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
