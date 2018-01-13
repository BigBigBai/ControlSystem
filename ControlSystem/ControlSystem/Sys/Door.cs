using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControlSystem.Sys
{
    /// <summary>
    /// 电子门
    /// </summary>
    public class Door
    {
        public const string OPEN = "电子门开启";
        public const string CLOSE = "电子门关闭";
        public string State { get; set; }// 电子门状态

        /// <summary>
        /// 构造函数
        /// </summary>
        public Door()
        {
            this.State = CLOSE;
        }

        /// <summary>
        /// 开启电子门
        /// </summary>
        public void Open()
        {
            this.State = OPEN;
        }

        /// <summary>
        /// 关闭电子门
        /// </summary>
        public void Close()
        {
            this.State = CLOSE;
        }
    }
}
