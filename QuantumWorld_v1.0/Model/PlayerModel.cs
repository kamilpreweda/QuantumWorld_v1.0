using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumWorld_v1._0.Model
{
    public class PlayerModel
    {
        public string Name { get; private set; }
        public ResourceModel CarbonFiber { get; private set; }
        public ResourceModel QuantumGlass { get; private set; }
        public ResourceModel HiggsBoson { get; private set; }
        public ResourceModel SolarEnergy { get; private set; }

        public ResourceModel[] PlayerResources { get; private set; }
        public BuildingModel CarbonFiberBuilding { get; private set; }
        public BuildingModel QuantumGlassBuilding { get; private set; }
        public BuildingModel HiggsBosonBuilding { get; private set; }
        public BuildingModel SolarEnergyBuilding { get; private set; }


    }
}
