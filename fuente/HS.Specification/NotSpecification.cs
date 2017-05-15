using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace HS
{
  class NotSpecification<T> : Specification<T> where T : class
  {
    private Specification<T> _spec;

    public NotSpecification(Specification<T> spec)
    {
      _spec = spec;
    }

    public override Expression<Func<T, bool>> SatisficiedBy()
    {
      var expr = _spec.SatisficiedBy();
      return Expression.Lambda<Func<T, bool>>(Expression.Not(expr.Body), expr.Parameters);
    }
  }
}
