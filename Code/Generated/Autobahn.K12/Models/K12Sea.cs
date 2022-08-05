//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12Sea.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12Sea
     /// </summary>
    public partial class K12Sea : AutobahnBase, Interfaces.IK12Sea
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefStateANSICode"/> model
        /// </summary>
        public Guid? RefStateANSICodeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
