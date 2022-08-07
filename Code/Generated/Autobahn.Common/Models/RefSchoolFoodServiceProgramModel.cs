//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefSchoolFoodServiceProgramModel.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefSchoolFoodServiceProgram Model
     /// </summary>
    public partial class RefSchoolFoodServiceProgramModel : ReferenceModelBase, IRefSchoolFoodServiceProgramModel
    {
        /// <summary>
        /// Defines the RefSchoolFoodServiceProgram.RefJurisdiction nullable property
        /// </summary>
        public System.Int32? RefJurisdiction { get; set; }

    }
}
