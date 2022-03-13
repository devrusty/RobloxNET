﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobloxNET
{
    internal class Types
    {

    }

    /*
     * The RobloxAsset class is meant to contain Roblox asset data that is sent 
     * by the Roblox API.
    */
    public class RobloxAsset
    {
        public RobloxAsset(
            long TargetId, 
            string ProductType, 
            long AssetId, 
            long ProductId, 
            string Name, 
            string Description, 
            long AssetTypeId, 
            Tuple<long, string> Creator, 
            long IconImageAssetId, 
            DateTime Created, 
            DateTime Updated, 
            int PriceInRobux, 
            int? PriceInTickets, 
            int Sales, 
            bool IsNew, 
            bool IsForSale, 
            bool IsPublicDomain, 
            bool IsLimited, 
            bool IsLimitedUnique, 
            int? Remaining, 
            int MinimumMembershipLevel
            )
        {
            this.TargetId = TargetId;
            this.ProductType = ProductType;
            this.AssetId = AssetId;
            this.ProductId = ProductId;
            this.Name = Name;
            this.Description = Description;
            this.AssetTypeId = AssetTypeId;
            this.Creator = Creator;
            this.IconImageAssetId = IconImageAssetId;
            this.Created = Created;
            this.Updated = Updated;
            this.PriceInRobux = PriceInRobux;
            this.PriceInTickets = PriceInTickets;
            this.Sales = Sales;
            this.IsNew = IsNew;
            this.IsForSale = IsForSale;
            this.IsPublicDomain = IsPublicDomain;
            this.IsLimited = IsLimited;
            this.IsLimitedUnique = IsLimitedUnique;
            this.Remaining = Remaining;
            this.MinimumMembershipLevel = MinimumMembershipLevel;
        }

        public long TargetId { get; set; }
        public string ProductType { get; set; }
        public long AssetId { get; set; }
        public long ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long AssetTypeId { get; set; }
        public Tuple<long, string> Creator { get; set; }
        public long IconImageAssetId { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public int PriceInRobux { get; set; }
        public int? PriceInTickets { get; set; }
        public int Sales { get; set; }
        public bool IsNew { get; set; }
        public bool IsForSale { get; set; }
        public bool IsPublicDomain { get; set; }
        public bool IsLimited { get; set; }
        public bool IsLimitedUnique { get; set; }
        public int? Remaining { get; set; }
        public int MinimumMembershipLevel { get; set; }
    }

    /*
     * The RobloxAssetVersion class is meant to contain Roblox asset version data 
     * that is sent by the Roblox API. A RobloxAssetVersion is the version of the asset
     * ,you can use it with the API here: api.roblox.com/assets/{id}/versions
    */
    public class RobloxAssetVersion
    {
        public RobloxAssetVersion(
            long Id, 
            long AssetId, 
            int VersionNumber, 
            long ParentAssetVersionId, 
            int CreatorType, 
            long CreatorTargetId, 
            long? CreatingUniverseId, 
            DateTime Created, 
            DateTime Updated
            )
        {
            this.Id = Id;
            this.AssetId = AssetId;
            this.VersionNumber = VersionNumber;
            this.ParentAssetVersionId = ParentAssetVersionId;
            this.CreatorType = CreatorType;
            this.CreatorTargetId = CreatorTargetId;
            this.CreatingUniverseId = CreatingUniverseId;
            this.Created = Created;
            this.Updated = Updated;
        }

        public long Id { get; set; }
        public long AssetId { get; set; }
        public int VersionNumber { get; set; }
        public long ParentAssetVersionId { get; set; }
        public int CreatorType { get; set; }
        public long CreatorTargetId { get; set; }
        public long? CreatingUniverseId { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }

    /*
     * The RobloxUser class is meant to contain Roblox user data that is sent   
     * by the Roblox API.
    */
    public class RobloxUser
    {
        public RobloxUser(
            long Id, 
            string Username, 
            string? AvatarUri, 
            bool AvatarFinal, 
            bool IsOnline
            )
        {
            // Setting the properties of the RobloxUser class from the constructor paramters

            this.Id = Id;
            this.Username = Username;
            this.AvatarUri = AvatarUri;
            this.AvatarFinal = AvatarFinal;
            this.IsOnline = IsOnline;
        }

        public long Id { get; set; }
        public string Username { get; set; }
        public string? AvatarUri { get; set; }
        public bool AvatarFinal { get; set; }
        public bool IsOnline { get; set; }
    }
}
