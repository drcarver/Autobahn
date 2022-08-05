//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefSchoolFoodServiceProgram.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The RefSchoolFoodServiceProgram Interface
     /// </summary>
    public partial interface IRefSchoolFoodServiceProgram : IReferenceModel
    {
        /// <summary>
        /// Defines the RefSchoolFoodServiceProgram.RefJurisdiction nullable property
        /// </summary>
        System.Int32? RefJurisdiction { get; set; }

    }
}
