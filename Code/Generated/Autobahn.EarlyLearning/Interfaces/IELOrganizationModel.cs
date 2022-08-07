//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   IELOrganizationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The IELOrganizationModel Interface
     /// </summary>
    public partial interface IELOrganizationModel : IAutobahnBase
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
