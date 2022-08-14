//**********************************************************
//* DomainName: Common Models
//* FileName:   IRefFoodServiceEligibility.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The RefFoodServiceEligibility Interface Model
     /// </summary>
    public partial interface IRefFoodServiceEligibility : IReferenceModel
    {
        /// <summary>
        /// An indication of a student's level of eligibility to participate in the National School Lunch Program for breakfast, lunch, snack, supper, and milk programs.
        /// </summary>
        System.Int32? RefJurisdiction { get; set; }

    }
}
