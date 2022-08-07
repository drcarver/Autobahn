//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefWeaponTypeList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefWeaponType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefWeaponTypeModel"> List
         /// </summary>
        public static List<RefWeaponTypeModel> RefWeaponTypeList = new List<RefWeaponTypeModel>
        {
            new RefWeaponType { Id=Guid.Parse("5402f7ad-3db3-469f-9a48-6b9f49a76f15"), Code="Firearm", Description="Firearm", Definition="Any weapon (including a starter gun) which will or is designed to or may readily be converted to expel a projectile by the action of an explosive;  the frame or receiver of any such weapon; any firearm muffler or firearm silencer; or any destructive device.", SortOrder=Convert.ToDecimal("0.00") },
            new RefWeaponType { Id=Guid.Parse("efb512dc-f8fb-4443-8919-5e5d38ab4151"), Code="Handgun", Description="Handgun", Definition="Any firearm which has a short stock and is designed to be held and fired by the use of a single hand.", SortOrder=Convert.ToDecimal("2.00") },
            new RefWeaponType { Id=Guid.Parse("7a49bb0e-0dc0-4a08-a3a2-8b9badcd4e23"), Code="Shotgun", Description="Shotgun", Definition="A weapon designed or redesigned, made or remade, and intended to be fired from the shoulder and designed or redesigned and made or remade to use the  energy of an explosive to fire through a smooth bore either a number of ball shots or a single projectile for each single pull of the trigger.", SortOrder=Convert.ToDecimal("4.00") },
            new RefWeaponType { Id=Guid.Parse("a9091065-119a-4e26-a8f8-c9d69620f2ce"), Code="Rifle", Description="Rifle", Definition="A weapon designed or redesigned, made or remade, and intended to be fired from the shoulder and designed or redesigned and made or remade to use the energy of an explosive to fire only a single projectile through a rifled bore for each single pull of the trigger.", SortOrder=Convert.ToDecimal("6.00") },
            new RefWeaponType { Id=Guid.Parse("d2c344bd-02ba-4e0d-ab62-ace7b5be7501"), Code="OtherFirearm", Description="Other Firearm", Definition="Other type of firearm", SortOrder=Convert.ToDecimal("8.00") },
            new RefWeaponType { Id=Guid.Parse("d02d44e9-37fa-4476-9325-dd173b947723"), Code="Knife", Description="Knife", Definition="The weapon involved was a knife.", SortOrder=Convert.ToDecimal("10.00") },
            new RefWeaponType { Id=Guid.Parse("a8acc1ec-d585-4b99-b59e-329970960f3a"), Code="KnifeLessThanTwoPointFiveInches", Description="Knife Less Than 2.5 Inches", Definition="Knife with blade length less than 2.5 inches - the weapon involved was a knife with a blade less than 2.5 inches in length.", SortOrder=Convert.ToDecimal("12.00") },
            new RefWeaponType { Id=Guid.Parse("8b917827-f85d-4d37-9403-14f190669402"), Code="KnifeLessThanThreeInches", Description="Knife Less Than Three Inches", Definition="Knife with blade length less than 3 inches in length - the weapon involved was a knife with a blade at least 2.5 inches in length, but less than 3 inches in length.", SortOrder=Convert.ToDecimal("14.00") },
            new RefWeaponType { Id=Guid.Parse("763a14c0-fb28-4e23-bd7c-f464148123a6"), Code="KnifeGreaterThanThreeInches", Description="Knife Greater Than Three Inches", Definition="Knife with blade length greater than or equal to 3 inches - the weapon involved was a knife with a blade 3 inches or greater in length.", SortOrder=Convert.ToDecimal("16.00") },
            new RefWeaponType { Id=Guid.Parse("3533d835-aa77-4a34-9a25-fb2af0d625f1"), Code="OtherSharpObject", Description="Other sharp object", Definition="The weapon involved was another type of sharp object, (e.g., razor blade, ice pick, dirk, Chinese star, other pointed instrument [used as a weapon]).", SortOrder=Convert.ToDecimal("18.00") },
            new RefWeaponType { Id=Guid.Parse("73531211-4e25-4040-a318-2b6c2463718f"), Code="OtherObject", Description="Other object", Definition="The weapon involved was another known object (e.g., chain, nunchakus, brass knuckle, billy club, electrical weapon or device [stun gun], BB or pellet gun).", SortOrder=Convert.ToDecimal("20.00") },
            new RefWeaponType { Id=Guid.Parse("576698b4-034a-4a30-bf38-81de951c4406"), Code="Substance", Description="Substance used as weapon", Definition="The weapon involved was a substance (e.g., mace, tear gas) that was used as a weapon.", SortOrder=Convert.ToDecimal("22.00") },
            new RefWeaponType { Id=Guid.Parse("9acf2241-12fb-4536-b480-fe3e5067df35"), Code="OtherWeapon", Description="Other weapon", Definition="The incident involved a weapon other than those described above.", SortOrder=Convert.ToDecimal("24.00") },
            new RefWeaponType { Id=Guid.Parse("2b2c3403-c347-4523-8785-366fad46c2f6"), Code="None", Description="None", Definition="No weapon was used in the incident", SortOrder=Convert.ToDecimal("26.00") },
            new RefWeaponType { Id=Guid.Parse("ca620780-790c-45b2-8998-20583ba0a6e4"), Code="Unknown", Description="Unknown weapon", Definition="A weapon was used in the incident, but the type is unknown.", SortOrder=Convert.ToDecimal("28.00") },
        };

        /// <summary>
        /// The Reference RefWeaponType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefWeaponTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefWeaponType { Id=Guid.Parse("5402f7ad-3db3-469f-9a48-6b9f49a76f15"), Description="Firearm", SortOrder=Convert.ToDecimal("0.00") },
            new RefWeaponType { Id=Guid.Parse("efb512dc-f8fb-4443-8919-5e5d38ab4151"), Description="Handgun", SortOrder=Convert.ToDecimal("2.00") },
            new RefWeaponType { Id=Guid.Parse("7a49bb0e-0dc0-4a08-a3a2-8b9badcd4e23"), Description="Shotgun", SortOrder=Convert.ToDecimal("4.00") },
            new RefWeaponType { Id=Guid.Parse("a9091065-119a-4e26-a8f8-c9d69620f2ce"), Description="Rifle", SortOrder=Convert.ToDecimal("6.00") },
            new RefWeaponType { Id=Guid.Parse("d2c344bd-02ba-4e0d-ab62-ace7b5be7501"), Description="Other Firearm", SortOrder=Convert.ToDecimal("8.00") },
            new RefWeaponType { Id=Guid.Parse("d02d44e9-37fa-4476-9325-dd173b947723"), Description="Knife", SortOrder=Convert.ToDecimal("10.00") },
            new RefWeaponType { Id=Guid.Parse("a8acc1ec-d585-4b99-b59e-329970960f3a"), Description="Knife Less Than 2.5 Inches", SortOrder=Convert.ToDecimal("12.00") },
            new RefWeaponType { Id=Guid.Parse("8b917827-f85d-4d37-9403-14f190669402"), Description="Knife Less Than Three Inches", SortOrder=Convert.ToDecimal("14.00") },
            new RefWeaponType { Id=Guid.Parse("763a14c0-fb28-4e23-bd7c-f464148123a6"), Description="Knife Greater Than Three Inches", SortOrder=Convert.ToDecimal("16.00") },
            new RefWeaponType { Id=Guid.Parse("3533d835-aa77-4a34-9a25-fb2af0d625f1"), Description="Other sharp object", SortOrder=Convert.ToDecimal("18.00") },
            new RefWeaponType { Id=Guid.Parse("73531211-4e25-4040-a318-2b6c2463718f"), Description="Other object", SortOrder=Convert.ToDecimal("20.00") },
            new RefWeaponType { Id=Guid.Parse("576698b4-034a-4a30-bf38-81de951c4406"), Description="Substance used as weapon", SortOrder=Convert.ToDecimal("22.00") },
            new RefWeaponType { Id=Guid.Parse("9acf2241-12fb-4536-b480-fe3e5067df35"), Description="Other weapon", SortOrder=Convert.ToDecimal("24.00") },
            new RefWeaponType { Id=Guid.Parse("2b2c3403-c347-4523-8785-366fad46c2f6"), Description="None", SortOrder=Convert.ToDecimal("26.00") },
            new RefWeaponType { Id=Guid.Parse("ca620780-790c-45b2-8998-20583ba0a6e4"), Description="Unknown weapon", SortOrder=Convert.ToDecimal("28.00") },
       };
   }
}
