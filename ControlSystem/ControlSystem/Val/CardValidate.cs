using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControlSystem.Val
{
    /// <summary>
    /// 胸卡验证方式
    /// </summary>
    public class CardValidate:Validate
    {
        /// <summary>
        /// 临时保存所有胸卡信息
        /// </summary>
        public object[] Inner { get; set; } 
        /// <summary>
        /// 临时保存需要验证的胸卡，以ca开头
        /// </summary>
        public object Input { get; set; }   
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="inner"></param>
        /// <param name="input"></param>
        public CardValidate(object[] inner, object input)
        {
            this.Inner = inner;
            this.Input = input;
        }
        /// <summary>
        /// 实现胸卡验证的方法
        /// </summary>
        /// <returns></returns>
        public bool Check()
        {
            string inputStr = null;

            if (this.Input != null && this.Inner != null)
            {
                try
                {
                    //得到当前刷卡人的卡号去掉ca
                    inputStr = ((string)this.Input).Substring(2);
                }
                catch (Exception ex)
                {
                    return false;
                }

                //通过循环来做比较验证
                for (int i = 0; i < this.Inner.Length; i++)
                {
                    //遍历数组，验证是否存在当前卡人的卡号
                    if (inputStr.Equals(this.Inner[i]))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
