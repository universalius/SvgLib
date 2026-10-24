using SvgLib;
using Xunit;

namespace SvgLib.Tests;

public class DefsTests
{
    [Fact]
    public void AddDefs_ShouldCreateDefsElement()
    {
        var svg = SvgDocument.Create();

        var defs = svg.AddDefs();

        Assert.NotNull(defs);
        Assert.Equal("defs", defs.Element.LocalName);
        Assert.Equal("defs", svg.Element.LastChild?.LocalName);
    }

    [Fact]
    public void AddPattern_ShouldCreatePatternElement()
    {
        var svg = SvgDocument.Create();

        var pattern = svg.AddPattern();

        Assert.NotNull(pattern);
        Assert.Equal("pattern", pattern.Element.LocalName);
        Assert.Equal("pattern", svg.Element.LastChild?.LocalName);
    }
}
