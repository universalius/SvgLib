using System.Xml;

namespace SvgLib
{
    public sealed class SvgDefs : SvgContainer
    {
        public SvgDefs(SvgDocument svgDocument) : base(null)
        {
            var element = svgDocument._document.CreateElement("defs", svgDocument.Element.OwnerDocument.DocumentElement.NamespaceURI);
            Element = element;
        }

        public SvgDefs(XmlElement element)
            : base(element)
        {
        }

        internal static SvgDefs Create(XmlElement parent)
        {
            var element = parent.OwnerDocument.CreateElement("defs", parent.OwnerDocument.DocumentElement.NamespaceURI);
            parent.AppendChild(element);
            return new SvgDefs(element);
        }
    }
}
