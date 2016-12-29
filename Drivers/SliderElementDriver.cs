using Lombiq.Layouts.Elements;
using Orchard.Environment.Extensions;
using Orchard.Layouts.Framework.Display;
using Orchard.Layouts.Framework.Drivers;

namespace Lombiq.Layouts.Drivers
{
    [OrchardFeature("Lombiq.Layouts.Slider")]
    public class SliderElementDriver : ElementDriver<Slider>
    {
        protected override EditorResult OnBuildEditor(Slider element, ElementEditorContext context)
        {
            var editor = context.ShapeFactory.EditorTemplate(TemplateName: "Elements.Slider", Model: element);

            if (context.Updater != null)
            {
                context.Updater.TryUpdateModel(element, context.Prefix, null, null);
            }

            return Editor(context, editor);
        }

        protected override void OnDisplaying(Slider element, ElementDisplayingContext context)
        {
            var depth = 0;
            var container = element.Container;
            do
            {
                depth++;
                container = container?.Container;
            } while (container != null);
            var position = element.Index;
            var identity = string.Format("{0}-{1}-{2}", context.Content.Id, depth, position);

            context.ElementShape.Identity = identity;
        }
    }
}