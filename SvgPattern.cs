using System.Xml;

namespace SvgLib
{
    public sealed class SvgPattern : SvgContainer
    {
        public SvgPattern(SvgDocument svgDocument) : base(null)
        {
            var element = svgDocument._document.CreateElement("pattern", svgDocument.Element.OwnerDocument.DocumentElement.NamespaceURI);
            Element = element;
        }

        public SvgPattern(XmlElement element)
            : base(element)
        {
        }

        internal static SvgPattern Create(XmlElement parent)
        {
            var element = parent.OwnerDocument.CreateElement("pattern", parent.OwnerDocument.DocumentElement.NamespaceURI);
            parent.AppendChild(element);
            return new SvgPattern(element);
        }

        public double X
        {
            get => Element.GetAttribute("x", 0.0);
            set => Element.SetAttribute("x", value);
        }

        public double Y
        {
            get => Element.GetAttribute("y", 0.0);
            set => Element.SetAttribute("y", value);
        }

        public double Width
        {
            get => Element.GetAttribute("width", 0.0);
            set => Element.SetAttribute("width", value);
        }

        public double Height
        {
            get => Element.GetAttribute("height", 0.0);
            set => Element.SetAttribute("height", value);
        }

        public string PatternUnits
        {
            get => Element.GetAttribute("patternUnits");
            set => Element.SetAttribute("patternUnits", value);
        }

        public string PatternContentUnits
        {
            get => Element.GetAttribute("patternContentUnits");
            set => Element.SetAttribute("patternContentUnits", value);
        }

        public string PatternTransform
        {
            get => Element.GetAttribute("patternTransform");
            set => Element.SetAttribute("patternTransform", value);
        }

        public SvgViewBox ViewBox
        {
            get => Element.GetAttribute("viewBox", new SvgViewBox());
            set => Element.SetAttribute("viewBox", value.ToString());
        }
    }
}
