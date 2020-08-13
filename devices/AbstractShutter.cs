namespace ShutterTester.devices
{
    /// <summary>
    /// Base class for all computer controlled shutter classes.
    /// </summary>
    /// 
    public abstract class AbstractShutter : IShutter
    {
        public abstract int Delay { get; set; }

        public abstract ShutterPosition ProbeState { get; set; }
        public abstract ShutterPosition LaserState { get; set; }

        public abstract ShutterPosition ToggleLaser();

        public abstract ShutterPosition ToggleProbe();

        public abstract void OpenLaser();

        public abstract void CloseLaser();

        public abstract void OpenProbe();

        public abstract void CloseProbe();

        public abstract void ToggleLaserAndProbe();

        public abstract void OpenLaserAndProbe();

        public abstract void CloseLaserAndProbe();
    }
}
