//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12leaTitleIiiprofessionalDevelopmentModel.cs
//***************************************************************************

using Autobahn.Interfaces.K12;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12leaTitleIiiprofessionalDevelopment Model
     /// </summary>
    public partial class K12leaTitleIiiprofessionalDevelopmentModel : AutobahnBase, IK12leaTitleIiiprofessionalDevelopment
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IK12lea"/> model
        /// </summary>
        public Guid K12leaId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IK12leatitleIiiprofessionalDevelopment"/> model
        /// </summary>
        public Guid K12leatitleIiiprofessionalDevelopmentId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTitleIiiprofessionalDevelopmentType"/> model
        /// </summary>
        public Guid RefTitleIiiprofessionalDevelopmentTypeId { get; set; }

    }
}
