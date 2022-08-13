//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12CharterSchoolAuthorizerAgencyModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12CharterSchoolAuthorizerAgency Model
     /// </summary>
    public partial class K12CharterSchoolAuthorizerAgencyModel : AutobahnBase, Interfaces.IK12CharterSchoolAuthorizerAgency
    {
        /// <summary>
        /// The type of agency that authorized the establishment or continuation of a charter school.
        /// </summary>
        public Guid? OrganizationId { get; set; }

        /// <summary>
        /// The type of agency that authorized the establishment or continuation of a charter school.
        /// </summary>
        public Guid RefCharterSchoolAuthorizerTypeId { get; set; }

    }
}
