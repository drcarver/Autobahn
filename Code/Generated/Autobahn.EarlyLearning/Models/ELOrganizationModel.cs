//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELOrganizationModel.cs
//***************************************************************************

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
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProfitStatus"/> model
        /// </summary>
        public Guid? RefProfitStatusId { get; set; }

    }
}
