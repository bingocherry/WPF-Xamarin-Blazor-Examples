﻿/*
*
* 文件名    ：Msg                             
* 程序说明  : 全局消息窗口提示
* 更新时间  : 2020-07-17 19:06
* 联系作者  : QQ:779149549 
* 开发者群  : QQ群:874752819
* 邮件联系  : zhouhaogg789@outlook.com
* 视频教程  : https://space.bilibili.com/32497462
* 博客地址  : https://www.cnblogs.com/zh7791/
* 项目地址  : https://github.com/HenJigg/WPF-Xamarin-Blazor-Examples
* 项目说明  : 以上所有代码均属开源免费使用,禁止个人行为出售本项目源代码
*/

namespace Consumption.ViewModel.Common
{
    using Consumption.Common.Contract;
    using Consumption.Core.Interfaces;
    using GalaSoft.MvvmLight.Messaging;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Text;
    using System.Threading.Tasks;

    public enum Notify
    {
        /// <summary>
        /// 错误
        /// </summary>
        [Description("错误")]
        Error,
        /// <summary>
        /// 警告
        /// </summary>
        [Description("警告")]
        Warning,
        /// <summary>
        /// 提示信息
        /// </summary>
        [Description("提示信息")]
        Info,
        /// <summary>
        /// 询问信息
        /// </summary>
        [Description("询问信息")]
        Question,
    }

    /// <summary>
    /// 消息类
    /// </summary>
    public class Msg
    {
        /// <summary>
        /// 信息提示
        /// </summary>
        /// <param name="msg"></param>
        public static async void Info(string msg)
        {
            await Show(Notify.Info, msg);
        }

        /// <summary>
        /// 错误提示
        /// </summary>
        /// <param name="msg"></param>
        public async static void Error(string msg)
        {
            await Show(Notify.Error, msg);
        }

        /// <summary>
        /// 真香警告
        /// </summary>
        /// <param name="msg"></param>
        public async static void Warning(string msg)
        {
            await Show(Notify.Warning, msg);
        }

        /// <summary>
        /// 真香询问
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        public async static Task<bool> Question(string msg)
        {
            return await Show(Notify.Question, msg);
        }

        /// <summary>
        /// 弹出窗口
        /// </summary>
        /// <param name="notify">类型</param>
        /// <param name="msg">文本信息</param>
        /// <returns></returns>
        private static async Task<bool> Show(Notify notify, string msg)
        {
            string Icon = string.Empty;
            string Color = string.Empty;
            switch (notify)
            {
                case Notify.Error:
                    Icon = "CommentRemoveOutline";
                    Color = "#FF4500";
                    break;
                case Notify.Warning:
                    Icon = "CommentWarning";
                    Color = "#FF8247";
                    break;
                case Notify.Info:
                    Icon = "CommentProcessingOutline";
                    Color = "#1C86EE";
                    break;
                case Notify.Question:
                    Icon = "CommentQuestionOutline";
                    Color = "#20B2AA";
                    break;
            }
            NetCoreProvider.Get("MsgCenter", out IMsg dialog);
            return await dialog.Show(new { Msg = msg, Color, Icon });
        }
    }
}
