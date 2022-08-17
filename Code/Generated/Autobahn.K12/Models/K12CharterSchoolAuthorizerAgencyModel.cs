//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12CharterSchoolAuthorizerAgencyModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The K12CharterSchoolAuthorizerAgency Model
     /// </summary>
    public partial class K12CharterSchoolAuthorizerAgencyModel : AutobahnBase, Interfaces.IK12CharterSchoolAuthorizerAgency
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid? OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefCharterSchoolAuthorizerType"/> model
        /// </summary>
        public Guid RefCharterSchoolAuthorizerTypeId { get; set; }

    }
}
