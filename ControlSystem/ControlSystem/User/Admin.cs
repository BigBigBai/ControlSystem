using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ControlSystem.Sys;

namespace ControlSystem.User
{
    /// <summary>
    /// 管理员
    /// </summary>
    public class Admin : Employee
    {
        //构造函数
        public Admin()
            : base()
        {
        }
        public Admin(int empId,string name)
            : base(empId,name)
        {
        }

        /// <summary>
        /// 管理员的工作方法1，开关电子门
        /// </summary>
        /// <param name="controlSys"></param>
        public void Work(ControlSys controlSys)
        {
            Console.WriteLine("管理员(" + this.Name + "，工号：" +this.EmpId + ")是否按开门按钮？[y/n]:");
            string btn = Console.ReadLine();
            if (btn.Equals("y"))
            {
                controlSys.OpenSign = 1;
                Console.WriteLine("管理员(" + this.Name + "，工号：" + this.EmpId + ")按下开门按钮,请入内！");
            }
            else
            {
                Console.WriteLine("管理员(" + this.Name + "，工号：" + this.EmpId + ")拒绝开门");
            }
        }

        /// <summary>
        /// 管理员的工作方法2，监控门铃
        /// </summary>
        /// <param name="controlSys"></param>
        /// <param name="guest"></param>
        public void Work(ControlSys controlSys, Caller caller)
        {
            if (controlSys.Ring == 1)
            {
                Console.WriteLine("访客(" + caller.Name + ")在按门铃");
                this.Work(controlSys);

                controlSys.Ring = 0;
                Console.WriteLine("管理员(" + this.Name + "，工号：" + this.EmpId + ")关闭门铃");
            }
        }

        /// <summary>
        /// 管理员的工作方法3，录入新的验证信息
        /// </summary>
        /// <param name="controlSys"></param>
        /// <param name="valType"></param>
        /// <param name="valStr"></param>
        public void Work(ControlSys controlSys, string valType, string valInfo)
        {
            if (valType.Equals("pa"))
            {
                controlSys.ObjComputer.AddPassWord(int.Parse(valInfo));

                Console.WriteLine("管理员(" + this.Name + "，工号：" + this.EmpId + ")录入新的密码验证信息");
            }
            else if (valType.Equals("ca"))
            {
                controlSys.ObjComputer.AddCard(valInfo);
                Console.WriteLine("管理员(" + this.Name + "，工号：" + this.EmpId + ")录入新的胸卡验证信息");
            }
      
            else
            {
                Console.WriteLine("验证信息录入失败");
            }
        }
    }
}
