//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefProgramSponsorTypeModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The RefProgramSponsorType Interface Model
     /// </summary>
    public partial interface IRefProgramSponsorTypeModel : IReferenceModel
    {
        /// <summary>
        /// Defines the RefProgramSponsorType.RefJurisdiction nullable property
        /// </summary>
        System.Int32? RefJurisdiction { get; set; }

    }
}
