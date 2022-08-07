//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12SchoolCorrectiveActionModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12SchoolCorrectiveAction Model
     /// </summary>
    public partial class K12SchoolCorrectiveActionModel : AutobahnBase, Interfaces.IK12SchoolCorrectiveActionModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="K12School"/> model
        /// </summary>
        public Guid K12SchoolId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefCorrectiveActionType"/> model
        /// </summary>
        public Guid RefCorrectiveActionTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
