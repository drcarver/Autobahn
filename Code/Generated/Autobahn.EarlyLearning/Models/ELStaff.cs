//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   ELStaff.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The ELStaff
     /// </summary>
    public partial class ELStaff : AutobahnBase, Interfaces.IELStaff
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefChildDevelopmentAssociateType"/> model
        /// </summary>
        public Guid? RefChildDevelopmentAssociateTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
