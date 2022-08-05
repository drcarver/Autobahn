//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   IRefELProgramLicenseStatu.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The RefELProgramLicenseStatu Interface
     /// </summary>
    public partial interface IRefELProgramLicenseStatu : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefELProgramLicenseStatus"/> model
        /// </summary>
        Guid RefELProgramLicenseStatusId { get; set; }

    }
}
