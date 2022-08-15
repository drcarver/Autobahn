//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELOrganizationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The ELOrganization Model
     /// </summary>
    public partial class ELOrganizationModel : AutobahnBase, Interfaces.IELOrganization
    {
        /// <summary>
        /// An indication of the for-profit status of a facility.
        /// </summary>
        public Guid? RefProfitStatusId { get; set; }

    }
}
