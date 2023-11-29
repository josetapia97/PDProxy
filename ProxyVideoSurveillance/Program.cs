using ProxyVideoSurveillance;
using ProxyVideoSurveillance.Elements;
using ProxyVideoSurveillance.Proxy;

SecurityCamera camdormitorio = new SecurityCamera("Dormitorio");
camdormitorio.DisplayLiveFeed();

SecurityCameraProxy camDormitorioSeg = new SecurityCameraProxy(camdormitorio, false);
camDormitorioSeg.DisplayLiveFeed();

Console.WriteLine(camDormitorioSeg.ToString());
