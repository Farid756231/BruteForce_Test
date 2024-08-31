using OtpNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BruteForce_Test
{
    public class TwoFactorAuthentication
    {

        private readonly Totp otp;

        public TwoFactorAuthentication(string userSecretKey)
        {
            otp = new Totp(Base32Encoding.ToBytes(userSecretKey));
        }

        public string GenerateCode()
        {
            return otp.ComputeTotp();
        }

        public bool VerifyCode(string userCode)
        {
            return otp.VerifyTotp(userCode, out long timeStepMatched, new VerificationWindow(previous: 2, future: 2));
        }
    }
}
