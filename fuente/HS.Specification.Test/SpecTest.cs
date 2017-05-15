using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HS
{
  public abstract class SpecTest
  {
    private Specification<Clase> _spec;

    public SpecTest()
    {
      _spec = CrearSpec();
    }

    protected int TrueValue = 1;
    protected int FalseValue = 100;
    protected abstract Specification<Clase> CrearSpec();

    [Fact]
    public void NoNulo()
    {
      Assert.NotNull(_spec.SatisficiedBy());
    }

    [Fact]
    public void Verdadero()
    {
      var fnc = _spec.SatisficiedBy().Compile();
      Assert.True(fnc(new Clase { Entero = TrueValue }));
    }

    [Fact]
    public void Falso()
    {
      var fnc = _spec.SatisficiedBy().Compile();
      Assert.False(fnc(new Clase { Entero = FalseValue }));
    }
  }
}
