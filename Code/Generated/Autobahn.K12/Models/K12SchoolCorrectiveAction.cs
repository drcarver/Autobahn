//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12SchoolCorrectiveAction.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12SchoolCorrectiveAction
     /// </summary>
    public partial class K12SchoolCorrectiveAction : AutobahnBase, Interfaces.IK12SchoolCorrectiveAction
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
