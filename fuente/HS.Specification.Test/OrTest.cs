using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS
{
  public class OrTest : SpecTest
  {
    protected override Specification<Clase> CrearSpec()
    {
      var izqda = new DirectSpecification<Clase>(c => c.Entero < 10);
      return izqda.Or(new DirectSpecification<Clase>(c => c.Entero > 150));
    }
  }
}
