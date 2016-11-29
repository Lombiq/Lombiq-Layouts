using Orchard.UI.Resources;

namespace Lombiq.Layouts
{
    public class ResourceManifest : IResourceManifestProvider
    {
        public void BuildManifests(ResourceManifestBuilder builder)
        {
            var manifest = builder.Add();

            manifest.DefineScript("Lombiq.Layouts.LayoutEditor").SetUrl("LayoutEditor.js").SetDependencies("Layouts.LayoutEditor");

            manifest.DefineStyle("SlickTheme").SetUrl("../Content/Slick/slick-theme.css");
            manifest.DefineStyle("Slick").SetUrl("../Content/Slick/slick.css");
            manifest.DefineScript("Slick").SetUrl("Slick/slick.min.js", "Slick/slick.js").SetDependencies("jQuery");
        }
    }
}