using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ControlSystem.Sys;

namespace ControlSystem.User
{
    /// <summary>
    /// 外来客人
    /// </summary>
    public class Guest:Caller
    {
        public string Reason { get; set; }//来访原因
        //构造函数
        public Guest()
        {
        }
        public Guest(string name,string reason)
        {
            this.Name = name;
            this.Reason = reason;
        }

        /// <summary>
        /// 重写进入验证方法：外来客人按铃
        /// </summary>
        /// <param name="controlSys"></param>
        public override void EnterValidate(ControlSys controlSys)
        {
            Console.WriteLine("外来客人(" + this.Name + ")按门铃,"+this.Reason+ ",是否允许进入？[y/n]:");
            string btn = Console.ReadLine();
            if (btn.Equals("y"))
            {
                controlSys.Ring = 1;
            }
            else if (btn.Equals("n"))
            {
                return;
            }
        }
    }
}
