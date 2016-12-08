using Orchard.Environment.Extensions;
using Orchard.Layouts.Elements;
using Orchard.Layouts.Helpers;
using Orchard.Localization;
using System;
using System.ComponentModel.DataAnnotations;

namespace Lombiq.Layouts.Elements
{
    [OrchardFeature("Lombiq.Layouts.Slider")]
    public class Slider : Container
    {
        public override string Category { get { return "UI"; } }

        public override string ToolboxIcon { get { return "\uf1c5"; } }

        public override LocalizedString DisplayText { get { return T("Slider"); } }

        public override bool HasEditor { get { return true; } }


        [Range(0, Int32.MaxValue, ErrorMessage = "Please use a positive number.")]
        public int ItemsToShow
        {
            get { return this.Retrieve(x => x.ItemsToShow); }
            set { this.Store(x => x.ItemsToShow, value); }
        }

        public bool AutoHeight
        {
            get { return this.Retrieve(x => x.AutoHeight); }
            set { this.Store(x => x.AutoHeight, value); }
        }

        public int Autoplay
        {
            get { return this.Retrieve(x => x.Autoplay); }
            set { this.Store(x => x.Autoplay, value); }
        }

        public bool DisplayDots
        {
            get { return this.Retrieve(x => x.DisplayDots); }
            set { this.Store(x => x.DisplayDots, value); }
        }

        public bool DisplayNavigationButtons
        {
            get { return this.Retrieve(x => x.DisplayNavigationButtons); }
            set { this.Store(x => x.DisplayNavigationButtons, value); }
        }

        public bool DisplayNavigationOnTop
        {
            get { return this.Retrieve(x => x.DisplayNavigationOnTop); }
            set { this.Store(x => x.DisplayNavigationOnTop, value); }
        }

        public bool DisplayOnlyButtonsOnTop
        {
            get { return this.Retrieve(x => x.DisplayOnlyButtonsOnTop); }
            set { this.Store(x => x.DisplayOnlyButtonsOnTop, value); }
        }

        public TransitionStyle TransitionStyle
        {
            get { return this.Retrieve(x => x.TransitionStyle); }
            set { this.Store(x => x.TransitionStyle, value); }
        }

        public bool ItemsScaleUp
        {
            get { return this.Retrieve(x => x.ItemsScaleUp); }
            set { this.Store(x => x.ItemsScaleUp, value); }
        }
    }

    public enum TransitionStyle
    {
        fade,
        backSlide,
        goDown,
        fadeUp
    }
}