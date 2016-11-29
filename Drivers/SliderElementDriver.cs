using Lombiq.Layouts.Elements;
using Lombiq.Layouts.ViewModels;
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
            var viewModel = new SliderEditorViewModel {
                IsCarousel = element.IsCarousel,
                IsInfinite = element.IsInfinite,
                ItemsToShow = element.ItemsToShow,
                ItemsToScroll = element.ItemsToScroll,
                IsAutoplay = element.IsAutoplay,
                AutoplaySpeed = element.AutoplaySpeed
            };
            var editor = context.ShapeFactory.EditorTemplate(TemplateName: "Elements.Slider", Model: viewModel);

            if (context.Updater != null)
            {
                context.Updater.TryUpdateModel(viewModel, context.Prefix, null, null);
                element.IsCarousel = viewModel.IsCarousel;
                element.IsInfinite = viewModel.IsInfinite;
                element.ItemsToShow = viewModel.ItemsToShow;
                element.ItemsToScroll = viewModel.ItemsToScroll;
                element.IsAutoplay = viewModel.IsAutoplay;
                element.AutoplaySpeed = viewModel.AutoplaySpeed;
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
                container = container.Container;
            } while (container != null);
            var position = element.Index;
            var identity = string.Format("{0}-{1}-{2}", context.Content.Id, depth, position);

            context.ElementShape.Identity = identity;
        }
    }
}