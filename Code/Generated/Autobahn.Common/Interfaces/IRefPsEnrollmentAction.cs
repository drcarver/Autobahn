//**********************************************************
//* DomainName: Common Models
//* FileName:   IRefPsEnrollmentAction.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The RefPsEnrollmentAction Interface Model
     /// </summary>
    public partial interface IRefPsEnrollmentAction : IReferenceModel
    {
        /// <summary>
        /// The action taken with respect to postsecondary enrollment by the student who graduated from the school, LEA or state in the past two years.
        /// </summary>
        System.Int32? RefJurisdiction { get; set; }

    }
}
