using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyVideoSurveillance.Elements
{
    public class SecurityCamera : ISecurityCamera
    {
        private string _cameralocation;
        public SecurityCamera(string cameralocation)
        {
            _cameralocation = cameralocation;
        }
        public void DisplayLiveFeed()
        {
            Console.WriteLine($"Starting stream from {_cameralocation}");
        }
    }
}
