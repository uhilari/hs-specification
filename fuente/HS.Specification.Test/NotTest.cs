using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS
{
  public class NotTest : SpecTest
  {
    protected override Specification<Clase> CrearSpec()
    {
      var spec = new DirectSpecification<Clase>(c => c.Entero == 100);
      return spec.Not();
    }
  }
}
