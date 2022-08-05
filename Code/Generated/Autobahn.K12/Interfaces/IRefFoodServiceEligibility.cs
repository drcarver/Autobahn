//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IRefFoodServiceEligibility.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The RefFoodServiceEligibility Interface
     /// </summary>
    public partial interface IRefFoodServiceEligibility : IReferenceModel
    {
        /// <summary>
        /// Defines the RefFoodServiceEligibility.RefJurisdiction nullable property
        /// </summary>
        System.Int32? RefJurisdiction { get; set; }

    }
}
