using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControlSystem.Val
{
    /// <summary>
    /// 验证接口
    /// </summary>
    public interface Validate
    {    
        /// <summary>
        /// 验证方法
        /// </summary>
        /// <returns>验证是否成功</returns>
        bool Check();
    }
}
