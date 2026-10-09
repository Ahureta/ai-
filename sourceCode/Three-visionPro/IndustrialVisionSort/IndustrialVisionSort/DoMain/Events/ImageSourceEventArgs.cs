using Cognex.VisionPro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialVisionSort.DoMain.Events
{
    internal class ImageSourceEventArgs
    {
        internal CogFrameGrabbers cogFrameGrabbers { get; }
        internal ImageSourceEventArgs(CogFrameGrabbers cogFrameGrabbers)
        {
            cogFrameGrabbers = cogFrameGrabbers ?? throw new ArgumentNullException(nameof(cogFrameGrabbers));
        }
    }
}
