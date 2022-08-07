//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ProgramModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The Program Model
     /// </summary>
    public partial class ProgramModel : AutobahnBase, Interfaces.IProgramModel
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
