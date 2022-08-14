//**********************************************************
//* DomainName: Common Models
//* FileName:   IRefProgramSponsorType.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The RefProgramSponsorType Interface Model
     /// </summary>
    public partial interface IRefProgramSponsorType : IReferenceModel
    {
        /// <summary>
        /// A type of organization providing funds for a particular educational or service program or activity or for an individual's participation in the program or activity.
        /// </summary>
        System.Int32? RefJurisdiction { get; set; }

    }
}
