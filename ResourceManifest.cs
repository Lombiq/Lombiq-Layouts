using Orchard.UI.Resources;

namespace Lombiq.Layouts
{
    public class ResourceManifest : IResourceManifestProvider
    {
        public void BuildManifests(ResourceManifestBuilder builder)
        {
            var manifest = builder.Add();

            manifest.DefineScript("Lombiq.Layouts.LayoutEditor").SetUrl("LayoutEditor.js").SetDependencies("Layouts.LayoutEditor");

            manifest.DefineStyle("OwlCarouselTheme").SetUrl("../Content/OwlCarousel/owl.theme.css");
            manifest.DefineStyle("OwlCarouselCustomTheme").SetUrl("owl-carousel-custom-theme.min.css", "owl-carousel-custom-theme.css").SetDependencies("OwlCarouselTheme");
            manifest.DefineStyle("OwlCarouselTransitions").SetUrl("../Content/OwlCarousel/owl.transitions.css");
            manifest.DefineStyle("OwlCarousel").SetUrl("../Content/OwlCarousel/owl.carousel.css").SetDependencies("OwlCarouselCustomTheme", "OwlCarouselTransitions");
            manifest.DefineScript("OwlCarousel").SetUrl("owl.carousel.min.js", "owl.carousel.js").SetDependencies("jQuery");
        }
    }
}