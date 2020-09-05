using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;

namespace lab3._1
{
    class Filter_c
    {
        public Image<Gray, byte> filtergray(Image<Bgr, byte> image)
        {
            Image<Gray, byte> grayImage = image.Convert<Gray, byte>();

            return grayImage;
        }

        public Image<Gray, byte> filterlinear(Image<Bgr, byte> image, double num1, double num2)
        {
            Image<Gray, byte> grayImage = filtergray(image);
            var tempImage = grayImage.PyrDown();
            var destImage = tempImage.PyrUp();
            double cannyThreshold = num1;
            double cannyThresholdLinking = num2;
            Image<Gray, byte> cannyEdges = destImage.Canny(cannyThreshold, cannyThresholdLinking);
            return cannyEdges;
        }

        public Image<Bgr,byte> filtercartoony(Image<Bgr,byte> image, double num1, double num2, int n1, int n2, int n3, int n4)
        {
            Image<Gray, byte> cannyEdges = filterlinear(image, num1, num2);
            Image<Bgr, byte> cannyEdgesBgr = cannyEdges.Convert<Bgr, byte>();
            Image<Bgr, byte> resultImage = image.Sub(cannyEdgesBgr);

            for (int channel = 0; channel < resultImage.NumberOfChannels; channel++)
                for (int x = 0; x < resultImage.Width; x++)
                    for (int y = 0; y < resultImage.Height; y++)
                    {
                        byte color = resultImage.Data[y, x, channel];
                        if (color <= n1)
                            color = 0;
                        else if (color <= n2)
                            color = 25;
                        else if (color <= n3)
                            color = 180;
                        else if (color <= n4)
                            color = 210;
                        else
                            color = 255;
                        resultImage.Data[y, x, channel] = color;
                    }
            return resultImage;
        }
    }
}
