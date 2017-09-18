﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vexease.Views
{
    public partial class LoginForm : Form
    {
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
            ShowInTaskbar = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;//不可调整大小。可包括控件菜单栏、标题栏、“最大化”按钮和“最小化”按钮。只能使用“最大化”和“最小化”按钮改变大小。创建单线边框。

        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            Close();
            var admform = new AdmForm
            {
                StartPosition = FormStartPosition.CenterScreen,
                ShowIcon = true
            };
            admform.Show();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
            var userForm = new UserForm()
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            userForm.ShowIcon = true;
            userForm.Show();

        }

       
    }
}
