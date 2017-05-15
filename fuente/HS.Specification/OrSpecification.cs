using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace HS
{
  class OrSpecification<T> : BinarySpecification<T> where T : class
  {
    public OrSpecification(Specification<T> izqda, Specification<T> drcha) : base(izqda, drcha)
    {
    }

    public override Expression<Func<T, bool>> SatisficiedBy()
    {
      return Merge(Expression.OrElse);
    }
  }
}
