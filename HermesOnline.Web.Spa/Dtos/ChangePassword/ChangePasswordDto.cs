﻿namespace HermesOnline.Web.Spa.Dtos.ChangePassword
{
    public class ChangePasswordDto
    {
        public string OldPassword { get; set; }

        public string NewPassword { get; set; }

        public string ConfirmPassword { get; set; }
    }
}