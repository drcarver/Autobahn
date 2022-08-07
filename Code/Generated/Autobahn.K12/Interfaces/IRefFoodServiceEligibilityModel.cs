//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IRefFoodServiceEligibilityModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The RefFoodServiceEligibility Interface Model
     /// </summary>
    public partial interface IRefFoodServiceEligibilityModel : IReferenceModel
    {
        /// <summary>
        /// Defines the RefFoodServiceEligibility.RefJurisdiction nullable property
        /// </summary>
        System.Int32? RefJurisdiction { get; set; }

    }
}
