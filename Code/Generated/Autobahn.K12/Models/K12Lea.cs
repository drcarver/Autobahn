//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12Lea.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12Lea
     /// </summary>
    public partial class K12Lea : AutobahnBase, Interfaces.IK12Lea
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Defines the K12Lea.SupervisoryUnionIdentificationNumber non nullable property
        /// </summary>
        public System.String SupervisoryUnionIdentificationNumber { get; set; }

        /// <summary>
        /// Defines the K12Lea.CharterSchoolIndicator nullable property
        /// </summary>
        public System.Boolean? CharterSchoolIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLeaType"/> model
        /// </summary>
        public Guid? RefLeaTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLeaImprovementStatus"/> model
        /// </summary>
        public Guid? RefLeaImprovementStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPublicSchoolChoiceStatus"/> model
        /// </summary>
        public Guid? RefPublicSchoolChoiceStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCharterLeaStatus"/> model
        /// </summary>
        public Guid? RefCharterLeaStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
