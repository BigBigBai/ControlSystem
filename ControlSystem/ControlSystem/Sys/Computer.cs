using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ControlSystem.Sys;
using ControlSystem.Val;
namespace ControlSystem.Sys
{

    /// <summary>
    /// 门禁系统的计算机
    /// </summary>
    public class Computer
    {
        private string[] passWord = new string[100];  // 计算机存储的雇员密码，数字字符串
        private string[] card = new string[100];  // 计算机存储的雇员胸卡号，字符串形式
   

        /// <summary>
        /// 无参构造方法，创建一组测试用密码、指纹、卡号
        /// </summary>
        public Computer()
        {
            passWord[0] = "2468";
            card[0] = "abc";
        }
        /// <summary>
        /// 验证
        /// </summary>
        /// <param name="passStr"></param>
        /// <returns></returns>
        public bool ValidateInfo(string inputInfo)
        {
            Validate validate = null;
            string prefix = inputInfo.Substring(0, 2);
            /*验证密码*/
            if (prefix.Equals("pa")) //以pa开头才是有效的密码信息
            {
                validate = new PassWordValidate(passWord, inputInfo);
                return validate.Check();
            }
            /*验证胸卡*/
            else if (prefix.Equals("ca")) //以ca开头才是有效的胸卡信息
            {
                validate = new CardValidate(card, inputInfo);
                return validate.Check();
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 增加新胸卡
        /// </summary>
        /// <param name="card"></param>
        public void AddCard(string card)
        {
            for (int i = 0; i < 100; i++)
            {
                if (this.card[i] == null)
                {
                    this.card[i] = card;
                    return;
                }
            }
        }
        /// <summary>
        /// 增加新密码
        /// </summary>
        /// <param name="passWord"></param>
        public void AddPassWord(int passWord)
        {
            for (int i = 0; i < 100; i++)
            {
                if (this.passWord[i] == null)
                {
                    this.passWord[i] = passWord * 2 + "";
                    return;
                }
            }
        }
        /**
         * @return card
         */
        public string[] Card
        {
            get { return card; }
        }
        
        /**
         * @return passWord
         */
        public string[] PassWord
        {
            get { return passWord; }
        }
    }
}
