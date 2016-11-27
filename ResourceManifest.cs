using Orchard.UI.Resources;

namespace Lombiq.Layouts
{
    public class ResourceManifest : IResourceManifestProvider
    {
        public void BuildManifests(ResourceManifestBuilder builder)
        {
            var manifest = builder.Add();

            manifest.DefineScript("Lombiq.Layouts.LayoutEditor").SetUrl("LayoutEditor.js").SetDependencies("Layouts.LayoutEditor");
        }
    }
}