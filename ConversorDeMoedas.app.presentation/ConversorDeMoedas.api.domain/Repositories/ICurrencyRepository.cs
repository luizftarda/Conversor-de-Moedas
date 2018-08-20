using ConversorDeMoedas.api.domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConversorDeMoedas.api.domain.Repositories
{
    public interface ICurrencyRepository : IReadOnlyRepository<Currency>
    {
    }
}
