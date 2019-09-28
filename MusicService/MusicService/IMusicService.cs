using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MusicService
{
    /// <summary>
    /// Interface for Music service
    /// </summary>
    [ServiceContract]
    interface IMusicService
    {
        [OperationContract]
        Music GetMusic(string name);
    }
}
