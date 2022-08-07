//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   RefLicenseExemptList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The list of RefLicenseExempt Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefLicenseExemptModel"> List
         /// </summary>
        public static List<RefLicenseExemptModel> RefLicenseExemptList = new List<RefLicenseExemptModel>
        {
            new RefLicenseExempt { Id=Guid.Parse("a55af854-495a-4564-bc59-6b428df8b153"), Code="Yes", Description="Yes", Definition="", SortOrder=Convert.ToDecimal("1.00") },
            new RefLicenseExempt { Id=Guid.Parse("c64eac2f-f7d2-4d7c-8fdc-b01c35feb14c"), Code="No", Description="No", Definition="", SortOrder=Convert.ToDecimal("2.00") },
            new RefLicenseExempt { Id=Guid.Parse("92c3aa5e-4843-4fbf-8da8-52db8d056a8a"), Code="NA", Description="Not applicable", Definition="", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The Reference RefLicenseExempt Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefLicenseExemptViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefLicenseExempt { Id=Guid.Parse("a55af854-495a-4564-bc59-6b428df8b153"), Description="Yes", SortOrder=Convert.ToDecimal("1.00") },
            new RefLicenseExempt { Id=Guid.Parse("c64eac2f-f7d2-4d7c-8fdc-b01c35feb14c"), Description="No", SortOrder=Convert.ToDecimal("2.00") },
            new RefLicenseExempt { Id=Guid.Parse("92c3aa5e-4843-4fbf-8da8-52db8d056a8a"), Description="Not applicable", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
