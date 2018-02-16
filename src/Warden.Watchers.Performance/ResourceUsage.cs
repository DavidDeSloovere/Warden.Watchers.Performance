﻿namespace Warden.Watchers.Performance
{
    /// <summary>
    /// Usage of the resources such as CPU and RAM.
    /// </summary>
    public class ResourceUsage
    {
        /// <summary>
        /// Percentage usage of the CPU.
        /// </summary>
        public double Cpu { get; }

        /// <summary>
        /// Megabytes usage of the RAM.
        /// </summary>
        public double Ram { get; }

        protected ResourceUsage(double cpu, double ram)
        {
            Cpu = cpu;
            Ram = ram;
        }

        ///<summary>
        /// Factory method for creating a new instance of ResourceUsage.
        /// </summary>
        /// <param name="cpu">Percentage usage of the CPU.</param>
        /// <param name="memory">Megabytes usage of the RAM.</param>
        /// <returns>Instance of ResourceUsage.</returns>
        public static ResourceUsage Create(double cpu, double memory)
            => new ResourceUsage(cpu, memory);
    }
}