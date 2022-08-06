//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefWeaponTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefWeaponType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefWeaponType"> List
         /// </summary>
        public static List<RefWeaponType> RefWeaponTypeList = new List<RefWeaponType>
        {
            new RefWeaponType { Id=Guid.Parse("438a1e24-e2b9-4a9d-b46a-851578436736"), Code="Firearm", Description="Firearm", Definition="Any weapon (including a starter gun) which will or is designed to or may readily be converted to expel a projectile by the action of an explosive;  the frame or receiver of any such weapon; any firearm muffler or firearm silencer; or any destructive device.", SortOrder=Convert.ToDecimal("0.00") },
            new RefWeaponType { Id=Guid.Parse("17992858-fff5-47dc-9fdc-41e24d2a75b0"), Code="Handgun", Description="Handgun", Definition="Any firearm which has a short stock and is designed to be held and fired by the use of a single hand.", SortOrder=Convert.ToDecimal("2.00") },
            new RefWeaponType { Id=Guid.Parse("0dab84a6-ed0b-45da-927a-36111665ee72"), Code="Shotgun", Description="Shotgun", Definition="A weapon designed or redesigned, made or remade, and intended to be fired from the shoulder and designed or redesigned and made or remade to use the  energy of an explosive to fire through a smooth bore either a number of ball shots or a single projectile for each single pull of the trigger.", SortOrder=Convert.ToDecimal("4.00") },
            new RefWeaponType { Id=Guid.Parse("f96226cd-6044-487a-b0ab-c6603776f6d2"), Code="Rifle", Description="Rifle", Definition="A weapon designed or redesigned, made or remade, and intended to be fired from the shoulder and designed or redesigned and made or remade to use the energy of an explosive to fire only a single projectile through a rifled bore for each single pull of the trigger.", SortOrder=Convert.ToDecimal("6.00") },
            new RefWeaponType { Id=Guid.Parse("6e1dac9c-775f-4057-9fe7-005caa096c10"), Code="OtherFirearm", Description="Other Firearm", Definition="Other type of firearm", SortOrder=Convert.ToDecimal("8.00") },
            new RefWeaponType { Id=Guid.Parse("2f0562bb-9a65-49f1-8ef4-7a1b5454e1a2"), Code="Knife", Description="Knife", Definition="The weapon involved was a knife.", SortOrder=Convert.ToDecimal("10.00") },
            new RefWeaponType { Id=Guid.Parse("b3e4bb29-460a-4a1b-9ab4-46314e6d1c48"), Code="KnifeLessThanTwoPointFiveInches", Description="Knife Less Than 2.5 Inches", Definition="Knife with blade length less than 2.5 inches - the weapon involved was a knife with a blade less than 2.5 inches in length.", SortOrder=Convert.ToDecimal("12.00") },
            new RefWeaponType { Id=Guid.Parse("1b0a7391-d4e1-45f6-b590-fbbb6f84c25f"), Code="KnifeLessThanThreeInches", Description="Knife Less Than Three Inches", Definition="Knife with blade length less than 3 inches in length - the weapon involved was a knife with a blade at least 2.5 inches in length, but less than 3 inches in length.", SortOrder=Convert.ToDecimal("14.00") },
            new RefWeaponType { Id=Guid.Parse("baffa6f4-9eef-40f7-80f5-f4e424f98c19"), Code="KnifeGreaterThanThreeInches", Description="Knife Greater Than Three Inches", Definition="Knife with blade length greater than or equal to 3 inches - the weapon involved was a knife with a blade 3 inches or greater in length.", SortOrder=Convert.ToDecimal("16.00") },
            new RefWeaponType { Id=Guid.Parse("bea48ad8-edd0-4ce5-b894-faaaf53c0e18"), Code="OtherSharpObject", Description="Other sharp object", Definition="The weapon involved was another type of sharp object, (e.g., razor blade, ice pick, dirk, Chinese star, other pointed instrument [used as a weapon]).", SortOrder=Convert.ToDecimal("18.00") },
            new RefWeaponType { Id=Guid.Parse("023dffad-19f1-41b8-877e-98e340d5c03a"), Code="OtherObject", Description="Other object", Definition="The weapon involved was another known object (e.g., chain, nunchakus, brass knuckle, billy club, electrical weapon or device [stun gun], BB or pellet gun).", SortOrder=Convert.ToDecimal("20.00") },
            new RefWeaponType { Id=Guid.Parse("9bc40a43-5062-41bf-a843-e9dfc4e66598"), Code="Substance", Description="Substance used as weapon", Definition="The weapon involved was a substance (e.g., mace, tear gas) that was used as a weapon.", SortOrder=Convert.ToDecimal("22.00") },
            new RefWeaponType { Id=Guid.Parse("9ee3ed1f-d6d3-4884-a3a3-fc7f0addce4a"), Code="OtherWeapon", Description="Other weapon", Definition="The incident involved a weapon other than those described above.", SortOrder=Convert.ToDecimal("24.00") },
            new RefWeaponType { Id=Guid.Parse("0ca2eaef-45fd-41ce-a3ce-83afb9e7f402"), Code="None", Description="None", Definition="No weapon was used in the incident", SortOrder=Convert.ToDecimal("26.00") },
            new RefWeaponType { Id=Guid.Parse("38e7ce6f-a16c-4785-b416-704c938df4b1"), Code="Unknown", Description="Unknown weapon", Definition="A weapon was used in the incident, but the type is unknown.", SortOrder=Convert.ToDecimal("28.00") },
        };

        /// <summary>
        /// The RefWeaponType Pick List
         /// </summary>
        public static List<RefWeaponType> RefWeaponTypePickList = new List<RefWeaponType>
        {
            new RefWeaponType { Id=Guid.Parse("438a1e24-e2b9-4a9d-b46a-851578436736"), Code="Firearm", Description="Firearm", SortOrder=Convert.ToDecimal("0.00") },
            new RefWeaponType { Id=Guid.Parse("17992858-fff5-47dc-9fdc-41e24d2a75b0"), Code="Handgun", Description="Handgun", SortOrder=Convert.ToDecimal("2.00") },
            new RefWeaponType { Id=Guid.Parse("0dab84a6-ed0b-45da-927a-36111665ee72"), Code="Shotgun", Description="Shotgun", SortOrder=Convert.ToDecimal("4.00") },
            new RefWeaponType { Id=Guid.Parse("f96226cd-6044-487a-b0ab-c6603776f6d2"), Code="Rifle", Description="Rifle", SortOrder=Convert.ToDecimal("6.00") },
            new RefWeaponType { Id=Guid.Parse("6e1dac9c-775f-4057-9fe7-005caa096c10"), Code="OtherFirearm", Description="Other Firearm", SortOrder=Convert.ToDecimal("8.00") },
            new RefWeaponType { Id=Guid.Parse("2f0562bb-9a65-49f1-8ef4-7a1b5454e1a2"), Code="Knife", Description="Knife", SortOrder=Convert.ToDecimal("10.00") },
            new RefWeaponType { Id=Guid.Parse("b3e4bb29-460a-4a1b-9ab4-46314e6d1c48"), Code="KnifeLessThanTwoPointFiveInches", Description="Knife Less Than 2.5 Inches", SortOrder=Convert.ToDecimal("12.00") },
            new RefWeaponType { Id=Guid.Parse("1b0a7391-d4e1-45f6-b590-fbbb6f84c25f"), Code="KnifeLessThanThreeInches", Description="Knife Less Than Three Inches", SortOrder=Convert.ToDecimal("14.00") },
            new RefWeaponType { Id=Guid.Parse("baffa6f4-9eef-40f7-80f5-f4e424f98c19"), Code="KnifeGreaterThanThreeInches", Description="Knife Greater Than Three Inches", SortOrder=Convert.ToDecimal("16.00") },
            new RefWeaponType { Id=Guid.Parse("bea48ad8-edd0-4ce5-b894-faaaf53c0e18"), Code="OtherSharpObject", Description="Other sharp object", SortOrder=Convert.ToDecimal("18.00") },
            new RefWeaponType { Id=Guid.Parse("023dffad-19f1-41b8-877e-98e340d5c03a"), Code="OtherObject", Description="Other object", SortOrder=Convert.ToDecimal("20.00") },
            new RefWeaponType { Id=Guid.Parse("9bc40a43-5062-41bf-a843-e9dfc4e66598"), Code="Substance", Description="Substance used as weapon", SortOrder=Convert.ToDecimal("22.00") },
            new RefWeaponType { Id=Guid.Parse("9ee3ed1f-d6d3-4884-a3a3-fc7f0addce4a"), Code="OtherWeapon", Description="Other weapon", SortOrder=Convert.ToDecimal("24.00") },
            new RefWeaponType { Id=Guid.Parse("0ca2eaef-45fd-41ce-a3ce-83afb9e7f402"), Code="None", Description="None", SortOrder=Convert.ToDecimal("26.00") },
            new RefWeaponType { Id=Guid.Parse("38e7ce6f-a16c-4785-b416-704c938df4b1"), Code="Unknown", Description="Unknown weapon", SortOrder=Convert.ToDecimal("28.00") },
       };
   }
}
