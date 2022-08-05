//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefProgramSponsorType.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The RefProgramSponsorType Interface
     /// </summary>
    public partial interface IRefProgramSponsorType : IReferenceModel
    {
        /// <summary>
        /// Defines the RefProgramSponsorType.RefJurisdiction nullable property
        /// </summary>
        System.Int32? RefJurisdiction { get; set; }

    }
}
