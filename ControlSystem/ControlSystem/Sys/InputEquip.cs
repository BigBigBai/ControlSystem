using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControlSystem.Sys
{
    /// <summary>
    /// 输入设备
    /// </summary>
    public class InputEquip
    {
        public string Input { get; set; }// 输入信息，暂时保存用户输入的认证信息，如密码、胸卡信息、指纹信息等

        public InputEquip()
        {
        }
        /// <summary>
        /// 接受验证信息
        /// </summary>
        public void InputInfo()
        {
            Console.WriteLine("请提供身份验证信息：");
            string info = Console.ReadLine();
            this.Input = info;
        }

    }
}
