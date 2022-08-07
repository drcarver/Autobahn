//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   IELStaffModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The IELStaffModel Interface
     /// </summary>
    public partial interface IELStaffModel : IAutobahnBase
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
