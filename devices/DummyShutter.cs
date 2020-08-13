using System;

namespace ShutterTester.devices
{
    /// <summary>
    /// Dummy shutter object implemented using no-ops.
    /// </summary>
    public class DummyShutter : AbstractShutter
    {

        public override int Delay { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override ShutterPosition ProbeState { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override ShutterPosition LaserState { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void CloseLaser()
        {
            throw new NotImplementedException();
        }

        public override void CloseLaserAndProbe()
        {
            throw new NotImplementedException();
        }

        public override void CloseProbe()
        {
            throw new NotImplementedException();
        }

        public override void OpenLaser()
        {
            throw new NotImplementedException();
        }

        public override void OpenLaserAndProbe()
        {
            throw new NotImplementedException();
        }

        public override void OpenProbe()
        {
            throw new NotImplementedException();
        }

        public override ShutterPosition ToggleLaser()
        {
            throw new NotImplementedException();
        }

        public override void ToggleLaserAndProbe()
        {
            throw new NotImplementedException();
        }

        public override ShutterPosition ToggleProbe()
        {
            throw new NotImplementedException();
        }
    }
}
