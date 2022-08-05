//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   IELStaff.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The IELStaff
     /// </summary>
    public partial interface IELStaff : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefChildDevelopmentAssociateType"/> model
        /// </summary>
        Guid? RefChildDevelopmentAssociateTypeId { get; set; }

    }
}
