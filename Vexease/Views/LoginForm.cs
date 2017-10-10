﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Vexease.Controllers.Account;

namespace Vexease.Views
{
    public partial class LoginForm : Form
    {

        int t = 0;
        public LoginForm()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;//最大化不可用
            MinimizeBox = false;//最小化不可用
            //ControlBox = false;//上面三个按钮隐藏,以后用...
          
            FormBorderStyle = FormBorderStyle.FixedSingle;//不可调整大小。可包括控件菜单栏、标题栏、“最大化”按钮和“最小化”按钮。只能使用“最大化”和“最小化”按钮改变大小。创建单线边框。
            TxtPwd.Focus();
            // BtnLogin.Focus();
          //  TxtUserName.ForeColor = Color.FromArgb(255,128,128,128);
            TxtPwd.ForeColor = Color.FromArgb(255,128,128,128);
         //   TxtUserName.Text = "请输入用户名";
            TxtPwd.Text = "请输入密码";
            
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            if (t == 0)
            {
                var userForm = new UserForm();
                userForm.Show();
            }
            
            base.OnClosing(e);
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (PwdCtrl.Verify(TxtPwd.Text))
            {
                
            }
            t = 1;
            var admform = new AdmForm();            
            admform.Show();
            Close();
           
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {

            Close();
            

        }

        /*
          private void TxtUserName_Enter(object sender, EventArgs e)
         {
             if (TxtUserName.Text == "请输入用户名"||TxtUserName.Text=="用户名不能为空！")
             {
                 TxtUserName.Text = "";
                 TxtUserName.ForeColor = Color.FromArgb(255, 0, 0, 0);
             }

         }
 */

        /*
           private void TxtUserName_Leave(object sender, EventArgs e)
          {
              if (TxtUserName.Text == "")
              {
                  TxtUserName.Text = "用户名不能为空！";
                  TxtUserName.ForeColor = Color.FromArgb(255,240,128,128);
              }
          }*/

        private void TxtPwd_Enter(object sender, EventArgs e)
        {
            if (TxtPwd.Text == "请输入密码" || TxtPwd.Text == "密码不能为空！")
            {
               
                TxtPwd.Text = "";
                TxtPwd.ForeColor = Color.FromArgb(255, 0, 0, 0);
            }
        }

        private void TxtPwd_Leave(object sender, EventArgs e)
        {
            if (TxtPwd.Text == "")
            {
                TxtPwd.Text = "密码不能为空！";
                TxtPwd.ForeColor=Color.FromArgb(255,240,128,128);
            }
        }
        //“注册”点击事件
        private void LblRegister_Click(object sender, EventArgs e)
        {

        }
        //“忘记密码？”点击事件
        private void LblForgetPwd_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
