//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefProgressAchievingEnglishLanguageProficiencyIndicatorStatu.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.K12.Interfaces;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The RefProgressAchievingEnglishLanguageProficiencyIndicatorStatu Model
     /// </summary>
    public partial class RefProgressAchievingEnglishLanguageProficiencyIndicatorStatu : ReferenceModelBase, IRefProgressAchievingEnglishLanguageProficiencyIndicatorStatu
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefProgressAchievingEnglishLanguageProficiencyIndicatorStatus"/> model
        /// </summary>
        public Guid RefProgressAchievingEnglishLanguageProficiencyIndicatorStatusId { get; set; }

    }
}
