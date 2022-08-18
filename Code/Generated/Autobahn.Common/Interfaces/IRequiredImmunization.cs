//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IRequiredImmunization.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IRequiredImmunization Interface
     /// </summary>
    public partial interface IRequiredImmunization : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefImmunizationType"/> model
        /// </summary>
        Guid RefImmunizationTypeId { get; set; }

    }
}
