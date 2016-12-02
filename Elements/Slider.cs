using Orchard.Environment.Extensions;
using Orchard.Layouts.Elements;
using Orchard.Layouts.Helpers;
using Orchard.Localization;

namespace Lombiq.Layouts.Elements
{
    [OrchardFeature("Lombiq.Layouts.Slider")]
    public class Slider : Container
    {
        public override string Category { get { return "UI"; } }

        public override string ToolboxIcon { get { return "\uf1c5"; } }

        public override LocalizedString DisplayText { get { return T("Slider"); } }

        public override bool HasEditor { get { return true; } }


        public bool IsInfinite
        {
            get { return this.Retrieve(x => x.IsInfinite); }
            set { this.Store(x => x.IsInfinite, value); }
        }

        public int ItemsToShow
        {
            get { return this.Retrieve(x => x.ItemsToShow); }
            set { this.Store(x => x.ItemsToShow, value); }
        }

        public int ItemsToScroll
        {
            get { return this.Retrieve(x => x.ItemsToScroll); }
            set { this.Store(x => x.ItemsToScroll, value); }
        }

        public bool IsAutoplay
        {
            get { return this.Retrieve(x => x.IsAutoplay); }
            set { this.Store(x => x.IsAutoplay, value); }
        }

        public int AutoplaySpeed
        {
            get { return this.Retrieve(x => x.AutoplaySpeed); }
            set { this.Store(x => x.AutoplaySpeed, value); }
        }
    }
}