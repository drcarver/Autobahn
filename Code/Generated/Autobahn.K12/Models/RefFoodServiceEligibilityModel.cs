//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefFoodServiceEligibilityModel.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.K12.Interfaces;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The RefFoodServiceEligibility Model
     /// </summary>
    public partial class RefFoodServiceEligibilityModel : ReferenceModelBase, IRefFoodServiceEligibilityModel
    {
        /// <summary>
        /// Defines the RefFoodServiceEligibility.RefJurisdiction nullable property
        /// </summary>
        public System.Int32? RefJurisdiction { get; set; }

    }
}
