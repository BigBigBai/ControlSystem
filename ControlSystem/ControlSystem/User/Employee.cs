using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ControlSystem.Sys;

namespace ControlSystem.User
{
/// <summary>
/// 雇员
/// </summary>
public class Employee : Caller 
{
    public int EmpId { get; set; }  //工号

    public Employee()
    {
    }

    public Employee(int empId,string name) 
    {
        this.Name = name;
        this.EmpId = empId;
    }

     /// <summary>
     /// 雇员向门禁系统的输入设备输入验证信息
     /// </summary>
     /// <param name="controlSys"></param>
    public override void EnterValidate(ControlSys controlSys) 
    {
        controlSys.ObjInputEquip.InputInfo();
    }
}

}
