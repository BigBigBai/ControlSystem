using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ControlSystem.Sys;
using ControlSystem.Val;
using ControlSystem.User;

namespace ControlSystem
{
    class Program
    {
        /// <summary>
        /// 测试门禁系统
        /// </summary>
        /// <param name="controlSys">门禁系统</param>
        /// <param name="caller">访客</param>
        public static void ControlTest(ControlSys controlSys, Caller caller)
        {
            if (caller is Guest)
            {
                Admin admin = new Admin(12,"王石头");    // 管理员
                Console.WriteLine("门禁系统---外来人员测试");
                Console.WriteLine("***************************************************");
                caller.EnterValidate(controlSys);
                admin.Work(controlSys, caller);
                controlSys.Work();

            }
            else if (caller is Employee)
            {
                Console.WriteLine("门禁系统---公司员工测试");
                Console.WriteLine("***************************************************");
                caller.EnterValidate(controlSys);
                controlSys.Work();

            }
            else
            {
                Console.WriteLine("身份不明，拒绝进入");
            }

        }

        static void Main(string[] args)
        {
            //测试
            ControlSys controlSys = new ControlSys(); //门禁系统
            Caller caller = new Guest("李明","送报纸");
            ControlTest(controlSys, caller);

        }
    }
}
