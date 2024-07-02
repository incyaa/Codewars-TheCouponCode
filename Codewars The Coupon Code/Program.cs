namespace Codewars_The_Coupon_Code;

class Program
{
    public static bool CheckCoupon(string enteredCode, string correctCode, string currentDate, string expirationDate)
        =>  correctCode == enteredCode && DateTime.Parse(currentDate) <= DateTime.Parse(expirationDate);
    static void Main(string[] args)
    {
        CheckCoupon("123", "123", "September 5, 2014", "October 1, 2014");
    }
}