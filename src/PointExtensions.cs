namespace System.Drawing {
    using System;

    public static class PointExtensions {
        /// <summary>
        /// Subtracts points as if they were vectors
        /// </summary>
        public static PointF Subtract(this PointF self, PointF other) => new PointF(self.X - other.X, self.Y - other.Y);
        /// <summary>
        /// Computes square of the distance to origin (0,0)
        /// </summary>
        public static float LengthSquared(this PointF self) => self.DotProduct(self);
        /// <summary>
        /// Computes dot product of point coordinates (assumes point to be a vector).
        /// </summary>
        public static float DotProduct(this PointF value, PointF other) => (value.X * other.X) + (value.Y * other.Y);
        /// <summary>
        /// Computes the distance to origin (0,0)
        /// </summary>
        public static float Length(this PointF self) => (float)Math.Sqrt(self.LengthSquared());
        /// <summary>
        /// Checks if two points are within a certain distance from each other.
        /// </summary>
        public static bool Equals(this PointF value, PointF other, double maxDistance) =>
            value.Subtract(other).LengthSquared() < maxDistance * maxDistance;
        /// <summary>
        /// Scales the point as if it were a vector.
        /// </summary>
        public static PointF Scale(this PointF self, float scale) =>
            new PointF(scale * self.X, scale * self.Y);
    }
}
