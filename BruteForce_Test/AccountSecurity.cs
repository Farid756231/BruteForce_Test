using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BruteForce_Test
{
    public class AccountSecurity
    {
        private int failedLoginAttempts = 0;
        private readonly int maxFailedAttempts = 3;
        private bool isBlocked = false;
        private DateTime blockUntil = DateTime.MinValue;

        public bool IsBlocked => isBlocked && DateTime.Now < blockUntil;

        public void RecordFailedAttempt()
        {
            failedLoginAttempts++;
            if (failedLoginAttempts >= maxFailedAttempts)
            {
                BlockAccount();
            }
        }

        public void ResetFailedAttempts()
        {
            failedLoginAttempts = 0;
        }

        private void BlockAccount()
        {
            Console.WriteLine("Too many failed attempts. Blocking account for 5 minutes.");
            isBlocked = true;
            blockUntil = DateTime.Now.AddMinutes(5);
            ResetFailedAttempts();
        }
    }
}
