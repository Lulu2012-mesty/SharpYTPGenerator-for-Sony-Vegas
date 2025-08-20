using System;

namespace SharpYTPGenerator
{
    public class RandomUtil
    {
        private readonly Random _rng;
        public RandomUtil(int seed) { _rng = new Random(seed); }
        public double NextDouble(double min, double max) => min + _rng.NextDouble() * (max - min);
        public int NextInt(int min, int max) => _rng.Next(min, max);
        public bool Chance(double p) => _rng.NextDouble() < p;
    }
}
