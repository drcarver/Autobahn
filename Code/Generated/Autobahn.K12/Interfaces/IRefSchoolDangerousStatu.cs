//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IRefSchoolDangerousStatu.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The RefSchoolDangerousStatu Interface
     /// </summary>
    public partial interface IRefSchoolDangerousStatu : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefSchoolDangerousStatus"/> model
        /// </summary>
        Guid RefSchoolDangerousStatusId { get; set; }

    }
}
