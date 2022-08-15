//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELStaffModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The ELStaff Model
     /// </summary>
    public partial class ELStaffModel : AutobahnBase, Interfaces.IELStaff
    {
        /// <summary>
        /// Type of Child Development Associate credential as defined by options.
        /// </summary>
        public Guid? RefChildDevelopmentAssociateTypeId { get; set; }

    }
}
