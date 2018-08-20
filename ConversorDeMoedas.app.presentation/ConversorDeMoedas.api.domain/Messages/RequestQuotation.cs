using ConversorDeMoedas.api.domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConversorDeMoedas.api.domain.Messages
{
    public class RequestQuotation
    {
        public Currency From { get; set; }

        public Currency To { get; set; }

        public double Amount { get; set; }
    }
}
