using INSS.SERVICE.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace INSS.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculadorInssController : ControllerBase
    {
        readonly ICalculadorInss _calcularInssService;

        private readonly ILogger<CalculadorInssController> _logger;

        public CalculadorInssController(ICalculadorInss calcularInssService,
                                        ILogger<CalculadorInssController> logger)
        {
            _calcularInssService = calcularInssService;
            _logger = logger;
        }

        [HttpGet]
        [Route("api/calcular_desconto/{salario}/{data}")]
        public IActionResult CalcularDeducao(DateTime data, decimal salario)
        {
            if (salario <= 0) return BadRequest(new { erro = "Salário informado inválido!" });

            if (!DateTime.TryParse(data.ToString(), out var anoParsed)) return BadRequest(new { erro = "Data informada inválida." });

            var desconto = _calcularInssService.CalcularDesconto(anoParsed, salario);

            if (desconto < 0) return NotFound(new { erro = "Nenhuma aliquota referente ao ano informado foi encontrada.", salarioLiquido = salario});

            return Ok(new 
            {
                salarioBruto = $"R${salario}",
                salarioLiquido = $"R${salario - desconto}", 
                ano = anoParsed.Year, 
                descontoINSS = $"R${desconto}"
            });
        }
    }
}
