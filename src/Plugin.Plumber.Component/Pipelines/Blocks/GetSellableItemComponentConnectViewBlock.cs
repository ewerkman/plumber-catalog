﻿using Plugin.Plumber.Component.Attributes;
using Plugin.Plumber.Component.Commanders;
using Sitecore.Commerce.Core;
using Sitecore.Commerce.EntityViews;
using Sitecore.Commerce.Plugin.Catalog;

namespace Plugin.Plumber.Component.Pipelines.Blocks
{
    public class GetSellableItemComponentConnectViewBlock : GetComponentConnectViewBaseBlock
    {
        public GetSellableItemComponentConnectViewBlock(ViewCommander viewCommander, CatalogSchemaCommander catalogSchemaCommander) : base(viewCommander, catalogSchemaCommander)
        {
        }

        protected override bool ComponentShouldBeAddedToDataTemplate(EntityViewAttribute entityViewAttribute)
        {
            return entityViewAttribute.AddToSellableItemDataTemplate;
        }

        protected override bool IsSupportedEntity(CommerceEntity entity)
        {
            return entity is SellableItem;
        }
    }
}
