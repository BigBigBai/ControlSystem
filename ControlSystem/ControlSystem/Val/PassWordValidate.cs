using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControlSystem.Val
{
    /// <summary>
    /// 密码验证
    /// </summary>
    public class PassWordValidate : Validate
    {
        /// <summary>
        /// 临时保存所有密码信息
        /// </summary>
        public object[] Inner { get; set; } 
        /// <summary>
        /// 临时保存需要验证的用户密码，以pa开头，后跟数字
        /// </summary>
        public object Input { get; set; }   
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="inner"></param>
        /// <param name="input"></param>
        public PassWordValidate(object[] inner, object input)
        {
            this.Inner = inner;
            this.Input = input;
        }
        /// <summary>
        /// 实现密码验证方法
        /// </summary>
        /// <returns></returns>
        public  bool Check()
        {
            for (int i = 0; i < this.Inner.Length; i++)
            {
                int inputInt = 0;
                int innerInt = 0;
                try
                {
                    inputInt = int.Parse(((string)this.Input).Substring(2));  // 解析输入的密码
                }
                catch (Exception e)
                {
                    return false;
                }
                if (this.Inner[i] != null)
                {
                    innerInt = int.Parse((string)(this.Inner[i]));  // 取得已有的密码
                }
                if (innerInt != 0 && inputInt * 2 == innerInt)  // 加密规则是乘2
                {   
                    return true;
                }
            }
            return false;
        }
    }
}
