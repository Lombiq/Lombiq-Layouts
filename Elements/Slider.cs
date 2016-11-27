using Orchard.Layouts.Elements;
using Orchard.Localization;

namespace Lombiq.Layouts.Elements
{
    public class Slider : Container
    {
        public override string Category
        {
            get
            {
                return "Lombiq";
            }
        }

        public override string ToolboxIcon
        {
            get
            {
                return "\uf1c5";
            }
        }

        public override LocalizedString DisplayText
        {
            get
            {
                return T("Slider");
            }
        }

        public override bool HasEditor
        {
            get
            {
                return true;
            }
        }
    }
}