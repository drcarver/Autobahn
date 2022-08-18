//**********************************************************
//* DomainName: Common Models
//* FileName:   RequiredImmunizationModel.cs
//***************************************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RequiredImmunization Model
     /// </summary>
    public partial class RequiredImmunizationModel : AutobahnBase, Interfaces.IRequiredImmunization
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefImmunizationType"/> model
        /// </summary>
        public Guid RefImmunizationTypeId { get; set; }

    }
}
