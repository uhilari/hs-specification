using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HS
{
  public class AndTest: SpecTest
  {
    protected override Specification<Clase> CrearSpec()
    {
      Specification<Clase> izqda = new DirectSpecification<Clase>(c => c.Entero > 0);
      izqda &= new DirectSpecification<Clase>(c => c.Entero < 10);
      return izqda;
    }
  }
}
