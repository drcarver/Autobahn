//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   RefSchoolFoodServiceProgramModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

using Autobahn.Invalid.Interfaces;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The RefSchoolFoodServiceProgram Model
     /// </summary>
    public partial class RefSchoolFoodServiceProgram : ReferenceModelBase, Interfaces.IRefSchoolFoodServiceProgram
    {
        /// <summary>
        /// An indication of a student's participation in free, reduced price, full price breakfast, lunch, snack, supper, and milk programs.
        /// </summary>
        public System.Int32? RefJurisdiction { get; set; }

    }
}
