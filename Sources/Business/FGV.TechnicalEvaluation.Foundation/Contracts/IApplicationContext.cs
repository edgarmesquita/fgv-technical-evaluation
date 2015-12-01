using FGV.TechnicalEvaluation.Foundation.Entities;

namespace FGV.TechnicalEvaluation.Foundation.Contracts
{
    public interface IApplicationContext
    {
        ISorting[] BookOrdenation { get; }
    }
}