using System;

class Program7{
	
    public static int GenerateOTP(){
        Random random = new Random(); 
        int otp = random.Next(100000, 1000000); 
        return otp;
    }

    public static bool AreUniqueOTPs(int[] otpArray)
    {
        for (int i = 0; i < otpArray.Length; i++)  
        {
            for (int j = i + 1; j < otpArray.Length; j++)  
            {
                if (otpArray[i] == otpArray[j])  
                {
                    return false;  
                }
            }
        }
        return true;  
    }

    public static void Main(string[] args)
    {
        int[] otpArray = new int[10];  

        for (int i = 0; i < otpArray.Length; i++)
        {
            otpArray[i] = GenerateOTP();
            Console.WriteLine("OTP " + (i + 1) + ": " + otpArray[i]);  
        }

        // Check if the OTP numbers are unique
        bool unique = AreUniqueOTPs(otpArray);
        if (unique)
        {
            Console.WriteLine("All OTP numbers are unique!");
        }
        else
        {
            Console.WriteLine("Some OTP numbers are not unique.");
        }
    }
}
