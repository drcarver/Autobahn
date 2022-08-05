//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RequiredImmunization.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RequiredImmunization
     /// </summary>
    public partial class RequiredImmunization : AutobahnBase, Interfaces.IRequiredImmunization
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
