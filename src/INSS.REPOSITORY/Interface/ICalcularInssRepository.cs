using INSS.DOMAIN.Entities;
using System.Collections.Generic;

namespace INSS.REPOSITORY.Interface
{
    public interface ICalcularInssRepository
    {
        List<AliquotaEntity> ObterAliquotasPorAno(int ano);
        List<TetoEntity> ObterTetoPorAno(int ano);
    }
}
