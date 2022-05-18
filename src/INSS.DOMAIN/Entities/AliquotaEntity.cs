using System;

namespace INSS.DOMAIN.Entities
{
    public class AliquotaEntity
    {
        public Guid Id { get; set; }
        public int Ano { get; set; }
        public double Salario_Piso { get; set; }
        public double Salario_Teto { get; set; }
        public double Aliquota { get; set; }
    }
}