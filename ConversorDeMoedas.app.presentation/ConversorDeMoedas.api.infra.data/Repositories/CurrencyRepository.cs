using ConversorDeMoedas.api.domain.Models;
using ConversorDeMoedas.api.domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ConversorDeMoedas.api.infra.data.Repositories
{
    public class CurrencyRepository : ICurrencyRepository
    {
        public IEnumerable<Currency> All()
        {
            return null;
        }

        public IEnumerable<Currency> Where(Expression<Func<bool, Currency>> expression)
        {
            return null;
        }
    }
}
