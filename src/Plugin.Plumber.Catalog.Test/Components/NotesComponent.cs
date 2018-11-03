﻿using Sitecore.Commerce.Core;
using Plugin.Plumber.Catalog.Attributes;
using System.ComponentModel.DataAnnotations;
using Sitecore.Commerce.Plugin.Catalog;
using Sitecore.Commerce.Plugin.Inventory;
using Sitecore.Commerce.Plugin.Orders;
using Sitecore.Commerce.Plugin.Promotions;

namespace Plugin.Plumber.Catalog.Sample.Components
{
    [AddToEntityType(typeof(SellableItem))]
    [AddToEntityType(typeof(InventoryInformation))]
    [AddToEntityType(typeof(Promotion))]
    [AddToEntityType(typeof(Order))]
    [AddToAllEntityTypes]
    [EntityView("Notes")]
    public class NotesComponent : Component
    {
        [Property("External Notes", isRequired: true, showInList: true)]
        public string ExternalNotes { get; set; } = string.Empty;

        [Property("Internal Notes")]
        [Required]
        public string InternalNotes { get; set; } = string.Empty;
    }
}
