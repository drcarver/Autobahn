//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefHigherEducationInstitutionAccreditationStatu.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The RefHigherEducationInstitutionAccreditationStatu Interface
     /// </summary>
    public partial interface IRefHigherEducationInstitutionAccreditationStatu : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefHigherEducationInstitutionAccreditationStatus"/> model
        /// </summary>
        Guid RefHigherEducationInstitutionAccreditationStatusId { get; set; }

    }
}
