namespace Lab3
{
    public static class GeometryMethods
    {
        public static bool IsTriangleExist(int firstSide, int secondSide, int thirdSide)
        {
            if ((firstSide + secondSide > thirdSide) &&
               (firstSide + thirdSide > secondSide) &&
                (thirdSide + secondSide > firstSide))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
