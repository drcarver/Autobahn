//***************************************************************************
//* DomainName: Invalid or Unreferenced Models Interfaces (used by both models and View Models
//* FileName:   IRequiredImmunization.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Invalid.Interfaces
{
     /// <summary>
     /// The IRequiredImmunization Interface
     /// </summary>
    public partial interface IRequiredImmunization : IAutobahnBase
    {
        /// <summary>
        /// An indication that an immunization is specifically required by an organization or governing body.
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// An indication that an immunization is specifically required by an organization or governing body.
        /// </summary>
        Guid RefImmunizationTypeId { get; set; }

    }
}
