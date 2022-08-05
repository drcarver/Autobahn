//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   ELOrganization.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The ELOrganization
     /// </summary>
    public partial class ELOrganization : AutobahnBase, Interfaces.IELOrganization
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProfitStatus"/> model
        /// </summary>
        public Guid? RefProfitStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
