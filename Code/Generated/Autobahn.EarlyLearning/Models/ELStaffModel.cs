//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELStaffModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The ELStaff Model
     /// </summary>
    public partial class ELStaffModel : AutobahnBase, Interfaces.IELStaff
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefChildDevelopmentAssociateType"/> model
        /// </summary>
        public Guid? RefChildDevelopmentAssociateTypeId { get; set; }

    }
}
