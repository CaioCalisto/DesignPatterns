using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_1
{
    public class Camera
    {
        public Guid HardwareID { get; private set; }

        static Dictionary<int, Camera> _cameras = new Dictionary<int, Camera>();
        static object _lock = new object();

        private Camera()
        {
            HardwareID = Guid.NewGuid();
        }

        public static Camera GetCamera(int id)
        {
            lock (_lock)
            {
                if (_cameras.Count < 2)
                {
                    if (!_cameras.ContainsKey(id))
                        _cameras.Add(id, new Camera());
                }                
            }
            if (_cameras.ContainsKey(id))
                return _cameras[id];
            else
                return null;
        }

        

    }
}
