# ShutterTestApp
This application controls the position of a beam shutter.

The software sends serial commands to Numato USB GPIO controller, which enable or disables the GPIO 3.3 V outputs. The outputs are connected to a custom shutter driver called BeamFlags (Not described here).

![App Image](https://github.com/ilopezpe/ShutterTestApp/blob/master/ShutterTestApp.png)

This software can be tested with any serial port device, e.g. Arduino. A library is included to extend this to other general purpose hardware controllers.

This software was written with C# using MS Visual Studio. It depends on code inherited from https://github.com/asarnow
