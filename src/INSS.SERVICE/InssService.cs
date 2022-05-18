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
            int year = data.Year;

            // convert to double
            double formattedSalary = Decimal.ToDouble(salario);

            var aliquota = _calcularInssRepository.ObterAliquotasPorAno(year).Where(x => x.Salario_Piso <= formattedSalary && formattedSalary <= x.Salario_Teto).FirstOrDefault();

            var teto = _calcularInssRepository.ObterTetoPorAno(year).FirstOrDefault();

            return aliquota is null && teto is null ? AnoNaoEncontrado : (decimal)(aliquota is null ?  teto.Teto : (formattedSalary * aliquota.Aliquota)/100); 
        }
    }
}
