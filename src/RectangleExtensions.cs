namespace System.Drawing.Primitives {
    using System.Drawing;

    public static class RectangleExtensions {
        /// <summary>
        /// Gets the central point of the rectangle
        /// </summary>
        public static PointF Center(this RectangleF rect) =>
            new PointF(0.5f * (rect.Left + rect.Right), 0.5f * (rect.Top + rect.Bottom));

        /// <summary>
        /// Gets an intersection with other rectangle
        /// </summary>
        /// <param name="rect">Original rectangle</param>
        /// <param name="other">Rectangle to intersect with</param>
        public static RectangleF Intersection(this RectangleF rect, RectangleF other) {
            rect.Intersect(other);
            return rect;
        }
        /// <summary>
        /// Calculates the area of the rectangle
        /// </summary>
        public static double Area(this RectangleF rect) => rect.Width * rect.Height;
        /// <summary>
        /// Get a rectangle, that is enlarged by the specified amount.
        /// </summary>
        /// <seealso cref="RectangleF.Inflate(RectangleF,float,float)"/>
        public static RectangleF Inflated(this RectangleF rect, float x, float y) {
            if (x < 0 && rect.Width < x)
                return new RectangleF();
            if (y < 0 && rect.Height < y)
                return new RectangleF();
            rect.Inflate(x, y);
            return rect;
        }
        /// <summary>
        /// Checks if rectangle's <see cref="RectangleF.Width"/> larger than its <see cref="RectangleF.Height"/>
        /// </summary>
        public static bool IsHorizontal(this RectangleF rect) => rect.Width > rect.Height;
        /// <summary>
        /// Gets the top left point of the rectangle
        /// </summary>
        public static PointF TopLeft(this RectangleF rect) => rect.Location;
        /// <summary>
        /// Gets the top right point of the rectangle
        /// </summary>
        public static PointF TopRight(this RectangleF rect) => new PointF(rect.Right, rect.Top);
        /// <summary>
        /// Gets the bottom right point of the rectangle
        /// </summary>
        public static PointF BottomRight(this RectangleF rect) => new PointF(rect.Right, rect.Bottom);
        /// <summary>
        /// Gets the bottom left point of the rectangle
        /// </summary>
        public static PointF BottomLeft(this RectangleF rect) => new PointF(rect.Left, rect.Bottom);
        /// <summary>
        /// Gets corner points
        /// </summary>
        public static PointF[] Corners(this RectangleF rect) =>
            new[] { rect.TopLeft(), rect.TopRight(), rect.BottomRight(), rect.BottomLeft() };
    }
}
