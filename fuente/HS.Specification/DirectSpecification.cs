using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace HS
{
  public class DirectSpecification<T> : Specification<T> where T : class
  {
    private Expression<Func<T, bool>> _expresion;

    public DirectSpecification(Expression<Func<T, bool>> expresion)
    {
      _expresion = expresion;
    }

    public override Expression<Func<T, bool>> SatisficiedBy()
    {
      return _expresion;
    }
  }
}
