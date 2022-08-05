//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IRefPublicSchoolChoiceStatu.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The RefPublicSchoolChoiceStatu Interface
     /// </summary>
    public partial interface IRefPublicSchoolChoiceStatu : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefPublicSchoolChoiceStatus"/> model
        /// </summary>
        Guid RefPublicSchoolChoiceStatusId { get; set; }

    }
}
