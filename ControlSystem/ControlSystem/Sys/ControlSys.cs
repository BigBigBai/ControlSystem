using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace ControlSystem.Sys
{
    /// <summary>
    /// 门禁系统
    /// </summary>
    public class ControlSys
    {
        public Door ObjDoor { get; set; }           // 门禁系统的电子门
        public Computer ObjComputer { get; set; }         // 门禁系统的计算机
        public InputEquip ObjInputEquip { get; set; }      // 门禁系统的输入设备
        public int Ring { get; set; }            // 门铃，0为安静，1为鸣响
        public int OpenSign { get; set; }        // 开门信号，由管理员按下按钮时产生，1为开启信号

        /// <summary>
        /// 初始化
        /// </summary>
        public ControlSys()
        {
            this.ObjDoor = new Door();
            this.ObjComputer = new Computer();
            this.ObjInputEquip = new InputEquip();
            this.Ring = 0;
            this.OpenSign = 0;
            Console.WriteLine("门禁系统的使用方法\n" +
                  " 1.模拟密码验证：以“pa”开头，后跟密码(四位数字)\n" +
                  " 2.模拟胸卡验证：以“ca”开头的字符串\n" +               
                  " 3.模拟管理员按下开门按钮：输入“y”");
            Console.WriteLine("***************************************************");
            Console.WriteLine("门禁系统启动");
        }
        /// <summary>
        /// 门禁系统工作：检查设备状态，调度设备
        /// </summary>
        public void  Work()
        {
            //检查输入设备的输入缓存（针对雇员） 
            if (ObjInputEquip.Input != null)
            {
                if (ObjComputer.ValidateInfo(ObjInputEquip.Input))
                {
                    ObjDoor.Open();                     // 开启电子门 
                    Console.WriteLine("身份验证成功，请通过电子门");
                    ObjInputEquip.Input = null;      // 清空输入设备缓存
                }
                else
                {
                    Console.WriteLine("身份验证失败");
                }
            }
            //检查开门信号 （针对外来人员）
            if (this.OpenSign == 1)
            {
                ObjDoor.Open();                        // 开启电子门
                Console.WriteLine("管理员开启了电子门,访客进入");
                this.OpenSign = 0;               // 电子门开门信号归零
            }
            //访客进入后电子门状态改变 /
            if (ObjDoor.State.Equals(Door.OPEN))
            {
                ObjDoor.Close();                       // 关闭电子门
                Console.WriteLine("电子门关闭");
            }
        }
    }
}
