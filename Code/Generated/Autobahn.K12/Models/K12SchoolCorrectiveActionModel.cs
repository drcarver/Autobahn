//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12schoolCorrectiveActionModel.cs
//***************************************************************************

using Autobahn.Interfaces.K12;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12schoolCorrectiveAction Model
     /// </summary>
    public partial class K12schoolCorrectiveActionModel : AutobahnBase, IK12schoolCorrectiveAction
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IK12school"/> model
        /// </summary>
        public Guid K12schoolId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCorrectiveActionType"/> model
        /// </summary>
        public Guid RefCorrectiveActionTypeId { get; set; }

    }
}
