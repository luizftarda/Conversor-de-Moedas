using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ConversorDeMoedas.api.domain.Repositories
{
    public interface IReadOnlyRepository<T>
    {
        IEnumerable<T> All();

        IEnumerable<T> Where(Expression<Func<bool, T>> expression);
    }
}
