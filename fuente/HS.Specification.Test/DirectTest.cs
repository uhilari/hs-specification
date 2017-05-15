using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HS
{
  public class DirectTest: SpecTest
  {
    protected override Specification<Clase> CrearSpec()
    {
      return new DirectSpecification<Clase>(c => c.Entero == 1);
    }
  }
}
