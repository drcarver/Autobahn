//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonAssessmentPersonalNeedsProfileModel.cs
//***************************************************************************

using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonAssessmentPersonalNeedsProfile Model
     /// </summary>
    public partial class PersonAssessmentPersonalNeedsProfileModel : AutobahnBase, IPersonAssessmentPersonalNeedsProfile
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentPersonalNeedsProfile"/> model
        /// </summary>
        public Guid AssessmentPersonalNeedsProfileId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        public Guid PersonId { get; set; }

    }
}
