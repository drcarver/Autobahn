//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12CharterSchoolAuthorizerAgency.cs
//**********************************************************

using Autobahn.K12.Interfaces;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12CharterSchoolAuthorizerAgency
     /// </summary>
    public partial class K12CharterSchoolAuthorizerAgency : IK12CharterSchoolAuthorizerAgency
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid? OrganizationId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefCharterSchoolAuthorizerType"/> model
        /// </summary>
        public Guid RefCharterSchoolAuthorizerTypeId { get; set; }

        /// <summary>
        /// Defines the K12CharterSchoolAuthorizerAgency.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the K12CharterSchoolAuthorizerAgency.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
