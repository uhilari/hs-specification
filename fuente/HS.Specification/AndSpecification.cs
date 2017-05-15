using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace HS
{
  class AndSpecification<T>: BinarySpecification<T> where T: class
  {
    public AndSpecification(Specification<T> izqda, Specification<T> drcha)
      :base(izqda, drcha)
    {
    }

    public override Expression<Func<T, bool>> SatisficiedBy()
    {
      return Merge(Expression.AndAlso);
    }
  }
}
