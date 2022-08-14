//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   IRefSchoolFoodServiceProgram.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Invalid.Interfaces
{
     /// <summary>
     /// The RefSchoolFoodServiceProgram Interface Model
     /// </summary>
    public partial interface IRefSchoolFoodServiceProgram : IReferenceModel
    {
        /// <summary>
        /// An indication of a student's participation in free, reduced price, full price breakfast, lunch, snack, supper, and milk programs.
        /// </summary>
        System.Int32? RefJurisdiction { get; set; }

    }
}
