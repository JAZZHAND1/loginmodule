﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Login : Form
    {    

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            List<User_Credentials> users = new List<User_Credentials>();
            users.Add(new User_Credentials() { username = "Mushfiq", password = "abc1234" });
            users.Add(new User_Credentials() { username = "Nawsad", password = "cat1234" });
            string given_username = txtUser.Text;
            string given_password = txtPass.Text;
            bool status = false;

            foreach (var user in users)
            {
                string username = user.username, password = user.password;
                Check_user_validity validity = new Check_user_validity();
                status = validity.authenticate_user(username, password, given_username, given_password);
                if(status == true)
                {
                    break;
                }
            }

        }

        private void sign_up_btn_Click(object sender, EventArgs e)
        {
             SignUp Check = new SignUp();
             Check.Show();
             Hide();
        }
    }
}
