using System.Collections.Generic;

namespace _7.Military_Elite.Interfaces
{
    public interface IEngineer 
    {
        List<IRepair> Repairs { get; }
    }
}
