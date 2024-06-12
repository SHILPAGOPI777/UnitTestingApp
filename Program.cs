namespace NUnitDemonstrationproj
{

    class Program
    {
        static void Main(string[] args)
        {

        }
        // SHILPA GOPI 8893284 UNIT TEST
    }
    public static class Triangle
    {
        public static string ValidTriangle(int firstAngle, int secondAngle, int
        thirdAngle)
        {
            string result;
            if ((firstAngle + secondAngle + thirdAngle) == 180)
            {
                result = "The triangle is valid.";
            }
            else
            {
                result = "The triangle is NOT valid.";
            }
            return result;
        }
    }

}


