using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuronNetwork
{
    public class Topology
    {
        public int InputCount { get; }
        public int OutputCount { get; }
        public double LerningRate { get; }
        public List<int> HiddenLayers { get; }

        public Topology(int inputCount, int outputCount,double lerningRate, params int[] layers)
        {
            InputCount = inputCount;
            OutputCount = outputCount;
            LerningRate = lerningRate;
            HiddenLayers = new List<int>();
            HiddenLayers.AddRange(layers);
        }
    }
}
