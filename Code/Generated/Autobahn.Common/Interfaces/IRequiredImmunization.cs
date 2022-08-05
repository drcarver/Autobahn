//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRequiredImmunization.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IRequiredImmunization
     /// </summary>
    public partial interface IRequiredImmunization : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefImmunizationType"/> model
        /// </summary>
        Guid RefImmunizationTypeId { get; set; }

    }
}
