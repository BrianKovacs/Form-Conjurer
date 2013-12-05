using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using tessnet2;

namespace FormConjurerLib
{
    public class TesseractUtil
    {
        public void Return(string path)
        {   
            
            Tesseract tesseract = new Tesseract();
            Bitmap bitmap = new Bitmap(path);
            Point start = new Point(0,0);
            Rectangle rect = new Rectangle(start,bitmap.Size);
            var output = tesseract.DoOCR(bitmap, rect);
            string text = string.Empty;
            foreach (Word a in output)
            {
               text += a.Text;

            }
            int b = 0;

        }
    }
}
