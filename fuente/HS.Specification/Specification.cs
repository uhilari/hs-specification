using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace HS
{
  public abstract class Specification<T> where T: class
  {
    public abstract Expression<Func<T, bool>> SatisficiedBy();

    public Specification<T> And(Specification<T> spec)
    {
      if (spec == null) throw new ArgumentNullException(nameof(spec));
      return new AndSpecification<T>(this, spec);
    }

    public Specification<T> Or(Specification<T> spec)
    {
      if (spec == null) throw new ArgumentNullException(nameof(spec));
      return new OrSpecification<T>(this, spec);
    }

    public Specification<T> Not()
    {
      return new NotSpecification<T>(this);
    }

    public static Specification<T> operator&(Specification<T> izqda, Specification<T> drcha)
    {
      if (izqda == null) throw new ArgumentNullException(nameof(izqda));
      return izqda.And(drcha);
    }

    public static Specification<T> operator|(Specification<T> izqda, Specification<T> drcha)
    {
      if (izqda == null) throw new ArgumentNullException(nameof(izqda));
      return izqda.Or(drcha);
    }

    public static Specification<T> operator !(Specification<T> spec)
    {
      if (spec == null) throw new ArgumentNullException(nameof(spec));
      return spec.Not();
    }
  }
}
