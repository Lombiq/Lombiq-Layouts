﻿using Orchard.DisplayManagement.Descriptors;
using Orchard.Environment;
using Orchard.Environment.Extensions;
using Orchard.UI.Resources;

namespace Lombiq.Layouts.Handlers
{
    [OrchardFeature("Lombiq.Layouts.Slider")]
    public class LayoutEditorShapeEventHandler : IShapeTableProvider
    {
        private readonly Work<IResourceManager> _resourceManager;


        public LayoutEditorShapeEventHandler(Work<IResourceManager> resourceManager)
        {
            _resourceManager = resourceManager;
        }


        public void Discover(ShapeTableBuilder builder)
        {
            builder.Describe("EditorTemplate").OnDisplaying(context =>
            {
                if (context.Shape.TemplateName != "Parts.Layout")
                {
                    return;
                }

                _resourceManager.Value.Require("script", "Lombiq.Layouts.LayoutEditor");
            });
        }
    }
}