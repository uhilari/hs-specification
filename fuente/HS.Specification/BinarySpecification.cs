using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace HS
{
  internal abstract class BinarySpecification<T> : Specification<T> where T : class
  {
    public BinarySpecification(Specification<T> izqda, Specification<T> drcha)
    {
      Izqda = izqda;
      Drcha = drcha;
    }

    protected Specification<T> Izqda { get; }
    protected Specification<T> Drcha { get; }

    protected Expression<Func<T, bool>> Merge(Func<Expression, Expression, Expression> fncMerge)
    {
      var exprIzqda = Izqda.SatisficiedBy();
      var exprDrcha = Drcha.SatisficiedBy();

      var map = exprIzqda.Parameters
        .Select((f, i) => new { f, s = exprDrcha.Parameters[i] })
        .ToDictionary(p => p.s, p => p.f);
      var body = fncMerge(exprIzqda.Body, ParameterRebinder.ReplaceParameters(map, exprDrcha.Body));
      return Expression.Lambda<Func<T, bool>>(body, exprIzqda.Parameters);
    }
  }
}
