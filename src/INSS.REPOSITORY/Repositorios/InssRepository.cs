using INSS.DOMAIN.Entities;
using INSS.REPOSITORY.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace INSS.REPOSITORY.Repositorios
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
            Salario_Piso = 0,
            Salario_Teto = 1106.90,
            Aliquota = 8,
            Ano = 2011,
        },
        new AliquotaEntity
        {
            Id = Guid.NewGuid(),
            Salario_Piso = 1106.91,
            Salario_Teto = 1844.83,
            Aliquota = 9,
            Ano = 2011,
        },
        new AliquotaEntity
        {
            Id = Guid.NewGuid(),
            Salario_Piso = 1844.84,
            Salario_Teto = 3689.66,
            Aliquota = 11,
            Ano = 2011,
        },
        new AliquotaEntity
        {
            Id = Guid.NewGuid(),
            Salario_Piso = 0,
            Salario_Teto = 1000,
            Aliquota = 7,
            Ano = 2012,
        }
        ,new AliquotaEntity
        {
            Id = Guid.NewGuid(),
            Salario_Piso = 1000.01,
            Salario_Teto = 1500,
            Aliquota = 8,
            Ano = 2012,
        }
        ,new AliquotaEntity
        {
            Id = Guid.NewGuid(),
            Salario_Piso = 1500.01,
            Salario_Teto = 3000,
            Aliquota = 9,
            Ano = 2012,
        }

         ,new AliquotaEntity
        {
            Id = Guid.NewGuid(),
            Salario_Piso = 3000.01,
            Salario_Teto = 4000,
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
            Salario_Piso = 3689.67
        },
        new TetoEntity
        {
            Id = Guid.NewGuid(),
            Ano = 2012,
            Teto = 500,
            Salario_Piso = 4000.01
        }
    };
}
