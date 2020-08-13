﻿namespace ShutterTester.devices
{
    public enum ShutterPosition { Open, Closed }
    /// <summary>
    /// Interface for all shutter classes
    /// </summary>
    public interface IShutter
    {
        /// <summary>
        /// This is the waiting time for shutter to settle after moving
        /// </summary>
        int Delay { get; set; }

        /// <summary>
        /// This holds the current state of the probe light shutter
        /// </summary>
        ShutterPosition ProbeState { get; }

        /// <summary>
        /// This holds the current state of the laser shutter 
        /// </summary>
        ShutterPosition LaserState { get; }

        /// <summary>
        /// This commands the probe shutter to switch position
        /// </summary>
        /// <returns>ProbeState</returns>
        ShutterPosition ToggleProbe();

        /// <summary>
        /// This commands the laser shutter to switch position
        /// </summary>
        /// <returns>LaserState</returns>
        ShutterPosition ToggleLaser();

        /// <summary>
        /// This commands both probe and laser shutters to switch position
        /// </summary>
        void ToggleLaserAndProbe();

        /// <summary>
        /// This commands the shutter to open
        /// </summary>
        void OpenLaser();

        /// <summary>
        /// This commands the shutter to close
        /// </summary>
        void CloseLaser();

        /// <summary>
        /// This commands the shutter to open
        /// </summary>
        void OpenProbe();

        /// <summary>
        /// This commands the shutter to close
        /// </summary>
        void CloseProbe();

        /// <summary>
        /// This commands both shutters to open simultaneously
        /// </summary>
        void OpenLaserAndProbe();

        /// <summary>
        /// This commands both shutters to close simultaneously
        /// </summary>
        void CloseLaserAndProbe();
    }
}
