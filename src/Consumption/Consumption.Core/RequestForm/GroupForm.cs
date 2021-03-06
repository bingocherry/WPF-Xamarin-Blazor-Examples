﻿/*
*
* 文件名    ：GroupForm                             
* 程序说明  : 组及成员和模块信息
* 更新时间  : 2020-07-08 09：41
* 联系作者  : QQ:779149549 
* 开发者群  : QQ群:874752819
* 邮件联系  : zhouhaogg789@outlook.com
* 视频教程  : https://space.bilibili.com/32497462
* 博客地址  : https://www.cnblogs.com/zh7791/
* 项目地址  : https://github.com/HenJigg/WPF-Xamarin-Blazor-Examples
* 项目说明  : 以上所有代码均属开源免费使用,禁止个人行为出售本项目源代码
*/

namespace Consumption.Core.RequestForm
{
    using Consumption.Core.Entity;
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// 组及成员和模块信息
    /// </summary>
    public class GroupForm
    {
        public Group group { get; set; }

        public List<GroupFunc> groupFunc { get; set; }

        public List<GroupUser> groupUser { get; set; }
    }
}
