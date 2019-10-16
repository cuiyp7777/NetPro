using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebBasicApp._04反射and特性and工厂
{
    public class _00Attribute
    {
        //添加了两个自定义的特性，这两个特性会被分别附加在产品类型和产品接口

        /// <summary>
        /// 该特性用于附加在产品【类】型之上
        /// </summary>
        [AttributeUsage(AttributeTargets.Class)]
        public class ProductAttribute : Attribute
        {
            // 标注零件的成员
            private RoomParts myRoomPart;

            public ProductAttribute(RoomParts part)
            {
                this.myRoomPart = part;
            }

            public RoomParts RoomPart { get { return myRoomPart; } }
        }
        /// <summary>
        /// 该特性用于附加在产品【接口】类型之上
        /// </summary>
        [AttributeUsage(AttributeTargets.Interface)]
        public class ProductListAttribute : Attribute
        {
            // 产品类型集合
            private Type[] myList;

            public ProductListAttribute(Type[] products)
            {
                myList = products;
            }

            public Type[] ProductList { get { return myList; } }
        }
    }
}