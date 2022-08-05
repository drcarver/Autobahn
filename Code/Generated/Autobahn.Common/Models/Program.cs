//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   Program.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The Program
     /// </summary>
    public partial class Program : AutobahnBase, Interfaces.IProgram
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Defines the Program.CreditsRequired nullable property
        /// </summary>
        public System.Decimal? CreditsRequired { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
