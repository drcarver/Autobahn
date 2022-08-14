//**********************************************************
//* DomainName: Common Models
//* FileName:   RefFoodServiceEligibilityModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefFoodServiceEligibility Model
     /// </summary>
    public partial class RefFoodServiceEligibility : ReferenceModelBase, Interfaces.IRefFoodServiceEligibility
    {
        /// <summary>
        /// An indication of a student's level of eligibility to participate in the National School Lunch Program for breakfast, lunch, snack, supper, and milk programs.
        /// </summary>
        public System.Int32? RefJurisdiction { get; set; }

    }
}
