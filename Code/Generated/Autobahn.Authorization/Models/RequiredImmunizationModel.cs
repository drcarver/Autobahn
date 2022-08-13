//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   RequiredImmunizationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
{
     /// <summary>
     /// The RequiredImmunization Model
     /// </summary>
    public partial class RequiredImmunizationModel : AutobahnBase, Interfaces.IRequiredImmunization
    {
        /// <summary>
        /// An indication that an immunization is specifically required by an organization or governing body.
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// An indication that an immunization is specifically required by an organization or governing body.
        /// </summary>
        public Guid RefImmunizationTypeId { get; set; }

    }
}
