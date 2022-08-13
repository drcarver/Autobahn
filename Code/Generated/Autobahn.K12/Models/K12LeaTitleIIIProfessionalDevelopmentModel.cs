//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12LeaTitleIIIProfessionalDevelopmentModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12LeaTitleIIIProfessionalDevelopment Model
     /// </summary>
    public partial class K12LeaTitleIIIProfessionalDevelopmentModel : AutobahnBase, Interfaces.IK12LeaTitleIIIProfessionalDevelopment
    {
        /// <summary>
        /// The type of Title III professional development utilized.
        /// </summary>
        public Guid K12LeaId { get; set; }

        /// <summary>
        /// The type of Title III professional development utilized.
        /// </summary>
        public Guid K12LEATitleIIIProfessionalDevelopmentId { get; set; }

        /// <summary>
        /// The type of Title III professional development utilized.
        /// </summary>
        public Guid RefTitleIIIProfessionalDevelopmentTypeId { get; set; }

    }
}
