using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ControlSystem.Sys;

namespace ControlSystem.User
{
    /// <summary>
    /// 访客
    /// </summary>
    public abstract class Caller
    {
        public string Name { get; set; }//姓名

        /// <summary>
        /// 进入电子门验证
        /// </summary>
        /// <param name="controSys"></param>
        public abstract void EnterValidate(ControlSys controlSys);
    }
}
