//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IProgram.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IProgram
     /// </summary>
    public partial interface IProgram : IAutobahnBase
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
