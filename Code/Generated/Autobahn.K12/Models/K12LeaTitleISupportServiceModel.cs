//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12leaTitleIsupportServiceModel.cs
//***************************************************************************

using Autobahn.Interfaces.K12;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12leaTitleIsupportService Model
     /// </summary>
    public partial class K12leaTitleIsupportServiceModel : AutobahnBase, IK12leaTitleIsupportService
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IK12lea"/> model
        /// </summary>
        public Guid K12leaId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefK12leaTitleIsupportService"/> model
        /// </summary>
        public Guid RefK12leaTitleIsupportServiceId { get; set; }

    }
}
