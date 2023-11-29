using ProxyVideoSurveillance.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyVideoSurveillance.Proxy
{
    internal class SecurityCameraProxy : ISecurityCamera
    {
        private SecurityCamera _secCamera;
        private bool _hasAcced;
        public SecurityCameraProxy(SecurityCamera secCamera, bool hasAcced)
        {
            _secCamera = secCamera;
            _hasAcced = hasAcced;

        }
        public void DisplayLiveFeed()
        {
            if(_hasAcced)
            {
                _secCamera.DisplayLiveFeed();
            }
            else
            {
                Console.WriteLine("You dont have permission to access this camera");
            }
            
        }
    }
}
