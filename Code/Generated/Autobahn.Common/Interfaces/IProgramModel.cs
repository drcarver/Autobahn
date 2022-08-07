//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IProgramModel.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IProgramModel Interface
     /// </summary>
    public partial interface IProgramModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Defines the Program.CreditsRequired nullable property
        /// </summary>
        System.Decimal? CreditsRequired { get; set; }

    }
}
