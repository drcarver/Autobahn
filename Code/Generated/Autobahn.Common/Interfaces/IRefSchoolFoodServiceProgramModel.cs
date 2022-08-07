//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefSchoolFoodServiceProgramModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The RefSchoolFoodServiceProgram Interface Model
     /// </summary>
    public partial interface IRefSchoolFoodServiceProgramModel : IReferenceModel
    {
        /// <summary>
        /// Defines the RefSchoolFoodServiceProgram.RefJurisdiction nullable property
        /// </summary>
        System.Int32? RefJurisdiction { get; set; }

    }
}
