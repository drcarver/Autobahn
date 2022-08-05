//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   RefELProgramLicenseStatu.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.EarlyLearning.Interfaces;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The RefELProgramLicenseStatu Model
     /// </summary>
    public partial class RefELProgramLicenseStatu : ReferenceModelBase, IRefELProgramLicenseStatu
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefELProgramLicenseStatus"/> model
        /// </summary>
        public Guid RefELProgramLicenseStatusId { get; set; }

    }
}
