using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern._03Builder
{
    /// <summary>
    /// 创建一个产品对象需要的步骤【所有产品共用的步骤（方法）】
    /// </summary>
    class _04Director_Shop
    {
        public void Construct(_02Builder_VehicleBuilder vehicleBuilder)
        {
            vehicleBuilder.BuildFrame();
            vehicleBuilder.BuildEngine();
            vehicleBuilder.BuildWheels();
            vehicleBuilder.BuildDoors();
        }
    }
}
