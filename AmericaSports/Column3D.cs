using Syncfusion.Maui.Toolkit.Charts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmericaSports
{
    public class Column3D : ColumnSeries
    {
        protected override ChartSegment CreateSegment()
        {
            return new ColumnSegment3D();
        }
    }

    public class ColumnSegment3D : ColumnSegment
    {
        public float Depth { get; set; } = 10f;

        protected override void Draw(ICanvas canvas)
        {
            base.Draw(canvas);
            if (Series is not CartesianSeries series || series.ActualXAxis == null)
            {
                return;
            }

            if (!float.IsNaN(Left) && !float.IsNaN(Top) && !float.IsNaN(Right) && !float.IsNaN(Bottom))
            {
                var depthOffset = Depth;

                Color mainColor = Colors.Red;
                if (Fill is SolidColorBrush solidBrush)
                {
                    mainColor = solidBrush.Color;
                }

                var sidePath = new PathF();
                sidePath.MoveTo(Right, Top);
                sidePath.LineTo(Right + depthOffset, Top - depthOffset);
                sidePath.LineTo(Right + depthOffset, Bottom - depthOffset);
                sidePath.LineTo(Right, Bottom);
                sidePath.Close();

                var sideColor = mainColor.WithAlpha(0.6f);
                canvas.SetFillPaint(new SolidColorBrush(sideColor), new Rect() { Left = Right, Top = Top, Right = Right + depthOffset, Bottom = Bottom });
                canvas.FillPath(sidePath);

                var topTriangle = new PathF();
                topTriangle.MoveTo(Left + depthOffset, Top - depthOffset);
                topTriangle.LineTo(Right + depthOffset, Top - depthOffset);
                topTriangle.LineTo(Right, Top);
                topTriangle.LineTo(Left, Top);
                topTriangle.Close();
                 
                canvas.SetFillPaint(new SolidColorBrush(sideColor), new Rect() { Left = Left, Top = Top, Right = Right + depthOffset, Bottom = Top });
                canvas.FillPath(topTriangle);
            }
        }
    }
}
