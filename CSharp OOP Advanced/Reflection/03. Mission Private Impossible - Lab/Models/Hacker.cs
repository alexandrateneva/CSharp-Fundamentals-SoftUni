﻿namespace _03.Mission_Private_Impossible___Lab.Models
{
    public class Hacker
    {
        public string username = "securityGod82";

        public string Password { get; set; } = "mySuperSecretPassw0rd";

        private int Id { get; set; }

        public double BankAccountBalance { get; private set; }

        public void DownloadAllBankAccountsInTheWorld()
        {
        }
    }
}
