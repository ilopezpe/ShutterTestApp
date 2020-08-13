namespace ShutterTester.devices
{
    /// <summary>
    /// Class representing shutter control via Numato GPIO
    /// </summary>

    public class BeamFlags : AbstractShutter
    {
       // public IShutter beamflags { get; set; }

        #region Constants 
        // Numato GPIO library for setting digital output states
        // Using reverse logic 
        public const string GpioOutputsCmd = "00ff";
        public const string GpioMaskCmd = "c000";

        public const string OpenProbeCmd = "gpio clear E\r";
        public const string CloseProbeCmd = "gpio set E\r";

        public const string OpenLaserCmd = "gpio clear F\r";
        public const string CloseLaserCmd = "gpio set F\r";

        public const string OpenAllCmd = "gpio writeall 0000\r";
        public const string CloseAllCmd = "gpio writeall ffff\r";
        #endregion

        public const int DefaultDelay = 300;
        public override int Delay { get; set; } = DefaultDelay;

        public override ShutterPosition ProbeState { get; set; }
        public override ShutterPosition LaserState { get; set; }

        public override ShutterPosition ToggleLaser()
        {
            switch (LaserState)
            {
                case ShutterPosition.Closed:
                    OpenLaser();
                    break;
                case ShutterPosition.Open:
                    CloseLaser();
                    break;
            }
            return LaserState;
        }

        public override ShutterPosition ToggleProbe()
        {
            switch (ProbeState)
            {
                case ShutterPosition.Closed:
                    OpenProbe();
                    break;
                case ShutterPosition.Open:
                    CloseProbe();
                    break;
            }
            return ProbeState;
        }

        public override void OpenLaser()
        {
            LaserState = ShutterPosition.Open;
        }

        public override void CloseLaser()
        {
            LaserState = ShutterPosition.Closed;
        }

        public override void OpenProbe()
        {
            ProbeState = ShutterPosition.Open;
        }

        public override void CloseProbe()
        {
            ProbeState = ShutterPosition.Closed;
        }

        public override void ToggleLaserAndProbe()
        {
            ToggleProbe();
            ToggleLaser();
        }

        public override void OpenLaserAndProbe()
        {
            LaserState = ShutterPosition.Open;
            ProbeState = ShutterPosition.Open;
        }

        public override void CloseLaserAndProbe()
        {
            LaserState = ShutterPosition.Closed;
            ProbeState = ShutterPosition.Closed;
        }
    }
}
