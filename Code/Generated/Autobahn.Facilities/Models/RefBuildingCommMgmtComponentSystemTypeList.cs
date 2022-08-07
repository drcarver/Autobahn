//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefBuildingCommMgmtComponentSystemTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The list of RefBuildingCommMgmtComponentSystemType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefBuildingCommMgmtComponentSystemTypeModel"> List
         /// </summary>
        public static List<RefBuildingCommMgmtComponentSystemTypeModel> RefBuildingCommMgmtComponentSystemTypeList = new List<RefBuildingCommMgmtComponentSystemTypeModel>
        {
            new RefBuildingCommMgmtComponentSystemType { Id=Guid.Parse("77ab3fdf-d5fc-47bc-ab20-5dc7cc4d895a"), Code="02500", Description="Data", Definition="Data is specified as the type of system, interface, and management components for carrying voice, video, and data throughout a building.", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingCommMgmtComponentSystemType { Id=Guid.Parse("cc4ba2f9-4b6c-4c44-86aa-aadebf7647ec"), Code="14905", Description="Integrated (voice, data, video, etc.)", Definition="Integrated (voice, data, video, etc.) is specified as the type of system, interface, and management components for carrying voice, video, and data throughout a building.", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingCommMgmtComponentSystemType { Id=Guid.Parse("397f5ac1-a44c-4ca3-a297-1c4b62f773db"), Code="02501", Description="Public address system", Definition="Public address system is specified as the type of system, interface, and management components for carrying voice, video, and data throughout a building.", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingCommMgmtComponentSystemType { Id=Guid.Parse("4a5c5d67-3e94-4aba-8855-39853302f34e"), Code="02499", Description="Video", Definition="Video is specified as the type of system, interface, and management components for carrying voice, video, and data throughout a building.", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingCommMgmtComponentSystemType { Id=Guid.Parse("5a45a06c-383d-4931-94b4-360035ee4a02"), Code="02498", Description="Voice", Definition="Voice is specified as the type of system, interface, and management components for carrying voice, video, and data throughout a building.", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingCommMgmtComponentSystemType { Id=Guid.Parse("aa720d12-6414-41b8-82c8-8fd26889ff6b"), Code="09999", Description="Other", Definition="Other is specified as the type of system, interface, and management components for carrying voice, video, and data throughout a building.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The Reference RefBuildingCommMgmtComponentSystemType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefBuildingCommMgmtComponentSystemTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefBuildingCommMgmtComponentSystemType { Id=Guid.Parse("77ab3fdf-d5fc-47bc-ab20-5dc7cc4d895a"), Description="Data", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingCommMgmtComponentSystemType { Id=Guid.Parse("cc4ba2f9-4b6c-4c44-86aa-aadebf7647ec"), Description="Integrated (voice, data, video, etc.)", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingCommMgmtComponentSystemType { Id=Guid.Parse("397f5ac1-a44c-4ca3-a297-1c4b62f773db"), Description="Public address system", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingCommMgmtComponentSystemType { Id=Guid.Parse("4a5c5d67-3e94-4aba-8855-39853302f34e"), Description="Video", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingCommMgmtComponentSystemType { Id=Guid.Parse("5a45a06c-383d-4931-94b4-360035ee4a02"), Description="Voice", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingCommMgmtComponentSystemType { Id=Guid.Parse("aa720d12-6414-41b8-82c8-8fd26889ff6b"), Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
