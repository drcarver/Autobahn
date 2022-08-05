//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefSingleSexClassStatu.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The RefSingleSexClassStatu Interface
     /// </summary>
    public partial interface IRefSingleSexClassStatu : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefSingleSexClassStatus"/> model
        /// </summary>
        Guid RefSingleSexClassStatusId { get; set; }

    }
}
