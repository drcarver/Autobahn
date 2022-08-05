//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   IELOrganization.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The IELOrganization
     /// </summary>
    public partial interface IELOrganization : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProfitStatus"/> model
        /// </summary>
        Guid? RefProfitStatusId { get; set; }

    }
}
