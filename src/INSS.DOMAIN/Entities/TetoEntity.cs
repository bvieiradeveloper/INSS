using System;

namespace INSS.DOMAIN.Entities
{
    public class TetoEntity
    {
        public Guid Id { get; set; }
        public int Ano { get; set; }
        public double Teto { get; set; }
        public double Salario_Piso { get; set; }
    }
}
