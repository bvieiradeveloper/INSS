using INSS.SERVICE.Interfaces;
using INSS.REPOSITORY.Interface;
using System;
using System.Linq;

namespace INSS.SERVICE
{

    public class InssService : ICalculadorInss
    {
        private const int AnoNaoEncontrado = -1;
        readonly ICalcularInssRepository _calcularInssRepository;

        public InssService(ICalcularInssRepository calcularInssRepository)
        {
            _calcularInssRepository = calcularInssRepository;
        }

        public decimal CalcularDesconto(DateTime data, decimal salario)
        {
            int ano = data.Year;

            // convert to double
            double salarioFormatado = Decimal.ToDouble(salario);

            var aliquota = _calcularInssRepository.ObterAliquotasPorAno(ano).Where(x => x.SalarioPiso <= salarioFormatado && salarioFormatado <= x.SalarioTeto).FirstOrDefault();

            var teto = _calcularInssRepository.ObterTetoPorAno(ano).FirstOrDefault();

            return aliquota is null && teto is null ? AnoNaoEncontrado : (decimal)(aliquota is null ?  teto.Teto : (salarioFormatado * aliquota.Aliquota)/100); 
        }
    }
}
