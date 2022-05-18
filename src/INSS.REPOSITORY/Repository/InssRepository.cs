using INSS.DOMAIN.Entities;
using INSS.REPOSITORY.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace INSS.REPOSITORY.Repository
{
    public class InssRepository : ICalcularInssRepository
    {
        public List<AliquotaEntity> ObterAliquotasPorAno(int ano)
        {
            return FakeDataBase.MockAliquotaDB.Where(x => x.Ano == ano).ToList();
        }

        public List<TetoEntity> ObterTetoPorAno(int ano)
        {
            return FakeDataBase.MockTetoDB.Where(x => x.Ano == ano).ToList();
        }
    }
}

public static class FakeDataBase
{

    public static List<AliquotaEntity> MockAliquotaDB = new List<AliquotaEntity>()
    {
        new AliquotaEntity
        {
            Id = Guid.NewGuid(),
            SalarioPiso = 0,
            SalarioTeto = 1106.90,
            Aliquota = 8,
            Ano = 2011,
        },
        new AliquotaEntity
        {
            Id = Guid.NewGuid(),
            SalarioPiso = 1106.91,
            SalarioTeto = 1844.83,
            Aliquota = 9,
            Ano = 2011,
        },
        new AliquotaEntity
        {
            Id = Guid.NewGuid(),
            SalarioPiso = 1844.84,
            SalarioTeto = 3689.66,
            Aliquota = 11,
            Ano = 2011,
        },
        new AliquotaEntity
        {
            Id = Guid.NewGuid(),
            SalarioPiso = 0,
            SalarioTeto = 1000,
            Aliquota = 7,
            Ano = 2012,
        }
        ,new AliquotaEntity
        {
            Id = Guid.NewGuid(),
            SalarioPiso = 1000.01,
            SalarioTeto = 1500,
            Aliquota = 8,
            Ano = 2012,
        }
        ,new AliquotaEntity
        {
            Id = Guid.NewGuid(),
            SalarioPiso = 1500.01,
            SalarioTeto = 3000,
            Aliquota = 9,
            Ano = 2012,
        }

         ,new AliquotaEntity
        {
            Id = Guid.NewGuid(),
            SalarioPiso = 3000.01,
            SalarioTeto = 4000,
            Aliquota = 11,
            Ano = 2012,
        }

    };

    public static List<TetoEntity> MockTetoDB = new List<TetoEntity>()
    {
        new TetoEntity
        {
            Id = Guid.NewGuid(),
            Ano = 2011,
            Teto = 405.86,
            SalarioPiso = 3689.67
        },
        new TetoEntity
        {
            Id = Guid.NewGuid(),
            Ano = 2012,
            Teto = 500,
            SalarioPiso = 4000.01
        }
    };
}
