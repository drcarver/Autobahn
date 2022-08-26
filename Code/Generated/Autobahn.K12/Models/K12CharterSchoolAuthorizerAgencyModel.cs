//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12charterSchoolAuthorizerAgencyModel.cs
//***************************************************************************

using Autobahn.Interfaces.K12;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12charterSchoolAuthorizerAgency Model
     /// </summary>
    public partial class K12charterSchoolAuthorizerAgencyModel : AutobahnBase, IK12charterSchoolAuthorizerAgency
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid? OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCharterSchoolAuthorizerType"/> model
        /// </summary>
        public Guid RefCharterSchoolAuthorizerTypeId { get; set; }

    }
}
