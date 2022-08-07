//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12LeaTitleIIIProfessionalDevelopmentModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12LeaTitleIIIProfessionalDevelopment Model
     /// </summary>
    public partial class K12LeaTitleIIIProfessionalDevelopmentModel : AutobahnBase, Interfaces.IK12LeaTitleIIIProfessionalDevelopmentModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="K12LEATitleIIIProfessionalDevelopment"/> model
        /// </summary>
        public Guid K12LEATitleIIIProfessionalDevelopmentId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="K12Lea"/> model
        /// </summary>
        public Guid K12LeaId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefTitleIIIProfessionalDevelopmentType"/> model
        /// </summary>
        public Guid RefTitleIIIProfessionalDevelopmentTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
