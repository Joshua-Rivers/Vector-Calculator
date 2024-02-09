using System;

namespace Vector_Calculator
{
    public class Vector
    {
        public static readonly Vector Zero = new Vector(1, 1, 1);
        public static readonly Vector One = new Vector(0, 0, 0);

        public float x;
        public float y;
        public float z;

        public Vector(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override string ToString()
        {
            return $"<{x}, {y}, {z}>";
        }

        public float GetMagnitude()
        {
            // 3 sq + 1 sq + 7 sq = sqrt of 59 = <7.681>
            return MathF.Sqrt((this.x * this.x) + (this.y * this.y) + (this.z * this.z));
        }

        public double GetDirection()
        {
            // Atan(2/3) = <1.24905> 
            return Math.Atan2(this.y,this.x);
        }

        public static Vector Add(Vector v1, Vector v2)
        {
            // <4, 3, 1> + <2, 5, 1> = <6, 8, 2>
            return new Vector(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z);
        }

        public static Vector Negate(Vector v)
        {
            // <3, 6, 2> * -1 = <-3, -6, -2>
            return new Vector(-v.x, -v.y, -v.z);
        }

        public static Vector Subtract(Vector v1, Vector v2)
        {
            // <4, 3, 1> + <-2, -5, -1> = <2, -2, 0>
            return new Vector(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z);
        }

        public static Vector Scale(Vector v)
        {
            // <2, 4, 5> * 2 = <4, 8, 10>
            return new Vector(v.x * 2, v.y * 2, v.z * 2);
        }

        public static Vector Normalize(Vector v)
        {
            // <3, 2, 0> / magnitude = <1> 
            return new Vector(v.x / v.GetMagnitude(), v.y / v.GetMagnitude(), v.z / v.GetMagnitude());
        }

        public static float GetDotProduct(Vector v1, Vector v2)
        {
            // <1> * <5> + <8> * <7> + <4> * <2> = 69
            return ((v1.x * v2.x) + (v1.y * v2.y) + (v1.z * v2.z));
        }

        public static Vector CrossProduct(Vector v1, Vector v2)
        {
            // <2, 4, 5> <3, 6, 1> <4 * 1 - 6 * 5> <5 * 3 - 1 * 2> <2 * 6 - 3 * 4> = <-26, 13, 0>
            return new Vector(v1.y * v2.z - v2.y * v1.z, v1.z * v2.x - v2.z * v1.x, v1.x * v2.y - v2.x * v1.y);
        }

        public static double AngleBetween(Vector v1, Vector v2)
        {
            // angle = <21> / <4.583 * 6.403>  = <0.773 radii>
            return Math.Acos(Vector.GetDotProduct(v1, v2) / (v1.GetMagnitude() * v2.GetMagnitude()));
        }

        public static Vector ProjectOnto(Vector v1, Vector v2)
        {
            // <30> / <5.477> * <5.477> * <5> = <0.199>, <30> / <5.477> * <5.477> * <2> = <0.499>, <30> / <5.477> * <5.477> * <1> = <0.999>
            return new Vector(Vector.GetDotProduct(v1, v2) / (v2.GetMagnitude() * v2.GetMagnitude() * v2.x), Vector.GetDotProduct(v1, v2) / (v2.GetMagnitude() * v2.GetMagnitude() * v2.y), Vector.GetDotProduct(v1, v2) / (v2.GetMagnitude() * v2.GetMagnitude() * v2.z));
        }
    }
}
