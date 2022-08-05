//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12CharterSchoolAuthorizerAgency.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12CharterSchoolAuthorizerAgency
     /// </summary>
    public partial class K12CharterSchoolAuthorizerAgency : AutobahnBase, Interfaces.IK12CharterSchoolAuthorizerAgency
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
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
