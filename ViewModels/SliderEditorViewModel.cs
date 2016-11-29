using Orchard.Environment.Extensions;

namespace Lombiq.Layouts.ViewModels
{
    [OrchardFeature("Lombiq.Layouts.Slider")]
    public class SliderEditorViewModel
    {
        public bool IsCarousel { get; set; }

        public bool IsInfinite { get; set; }

        public int ItemsToShow { get; set; }

        public int ItemsToScroll { get; set; }

        public bool IsAutoplay { get; set; }

        public int AutoplaySpeed { get; set; }
    }
}