//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IRefProgressAchievingEnglishLanguageProficiencyIndicatorStatu.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The RefProgressAchievingEnglishLanguageProficiencyIndicatorStatu Interface
     /// </summary>
    public partial interface IRefProgressAchievingEnglishLanguageProficiencyIndicatorStatu : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefProgressAchievingEnglishLanguageProficiencyIndicatorStatus"/> model
        /// </summary>
        Guid RefProgressAchievingEnglishLanguageProficiencyIndicatorStatusId { get; set; }

    }
}
