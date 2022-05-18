using System;

namespace INSS.DOMAIN.Entities
{
    public class AliquotaEntity
    {
        public Guid Id { get; set; }
        public int Ano { get; set; }
        public double SalarioPiso { get; set; }
        public double SalarioTeto { get; set; }
        public double Aliquota { get; set; }
    }
}