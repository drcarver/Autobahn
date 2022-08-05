//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IRefNationalSchoolLunchProgramStatu.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The RefNationalSchoolLunchProgramStatu Interface
     /// </summary>
    public partial interface IRefNationalSchoolLunchProgramStatu : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefNationalSchoolLunchProgramStatus"/> model
        /// </summary>
        Guid RefNationalSchoolLunchProgramStatusId { get; set; }

    }
}
