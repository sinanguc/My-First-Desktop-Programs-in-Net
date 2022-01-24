using System;
using System.IO;
using System.Drawing;
using System.Drawing.Design;

//V1

	/// <summary>
	/// Summary description for CImage.
	/// </summary>
	public class CImage
	{
		public CImage()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		public static System.Drawing.Image ConvertByteArrayToImage(byte[] ImageArray) 
		{ 
			System.Drawing.Image Ret; 
			try 
			{   

				MemoryStream oStream = new MemoryStream(ImageArray,0,ImageArray.Length); 

				oStream.Write(ImageArray,0,ImageArray.Length); 
				Ret = Image.FromStream(oStream,true);   
				oStream.Close(); 
			} 
			catch (Exception e) { throw e;}   

			return Ret; 
		} 

		public static byte[] ConvertImageToByteArray(System.Drawing.Image ChartImage) 
		{ 
			byte[] Ret; 
			try 
			{   
				MemoryStream oStream = new MemoryStream();   
				
				ChartImage.Save(oStream,System.Drawing.Imaging.ImageFormat.Jpeg); 
				Ret = oStream.ToArray(); 
				oStream.Close(); 
			} 
			catch (Exception e) { throw e;}   

			return Ret; 
		} 

		public static Image Resizee (Image imgSource,int SizeLimit)
		{
			if (imgSource.Width > SizeLimit && imgSource.Height <= SizeLimit)
			{
				int oldwidth = imgSource.Width;
				int oldheight = imgSource.Height;
				imgSource = new Bitmap (imgSource,new Size (SizeLimit,SizeLimit*oldheight/oldwidth));
			}
			else if (imgSource.Height > SizeLimit && imgSource.Width <=SizeLimit)
			{
				int oldwidth = imgSource.Width;
				int oldheight = imgSource.Height;
				imgSource = new Bitmap (imgSource,new Size (SizeLimit*oldwidth/oldheight,SizeLimit));
			}
			else if (imgSource.Width > SizeLimit && imgSource.Height > SizeLimit)
			{
				int oldwidth = imgSource.Width;
				int oldheight = imgSource.Height;
				if (oldwidth > oldheight)
				{
					imgSource = new Bitmap (imgSource,new Size (SizeLimit,SizeLimit*oldheight/oldwidth));
				}
				else
				{
					imgSource = new Bitmap (imgSource,new Size (SizeLimit*oldwidth/oldheight,SizeLimit));
				}
			}
			return imgSource;
		}

        public static Image Resizee2(Image imgSource, int SizeLimit)
        {
            int newWidth = 0;
            int newHeight = 0;
            if (imgSource.Width > SizeLimit && imgSource.Height <= SizeLimit)
            {
                int oldwidth = imgSource.Width;
                int oldheight = imgSource.Height;
                newWidth = SizeLimit;
                newHeight = SizeLimit * oldheight / oldwidth;
                
            }
            else if (imgSource.Height > SizeLimit && imgSource.Width <= SizeLimit)
            {
                int oldwidth = imgSource.Width;
                int oldheight = imgSource.Height;
                newWidth = SizeLimit * oldwidth / oldheight;
                newHeight = SizeLimit;
              
            }
            else if (imgSource.Width > SizeLimit && imgSource.Height > SizeLimit)
            {
                int oldwidth = imgSource.Width;
                int oldheight = imgSource.Height;
                if (oldwidth > oldheight)
                {
                    newWidth = SizeLimit;
                    newHeight = SizeLimit * oldheight / oldwidth;
                 
                }
                else
                {
                    newWidth = SizeLimit * oldwidth / oldheight;
                    newHeight = SizeLimit;
                    
                }
            }

            Bitmap newImage = new Bitmap(newWidth, newHeight);
            using (Graphics gr = Graphics.FromImage(newImage))
            {
                gr.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                gr.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                gr.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                gr.DrawImage(imgSource, new Rectangle(0, 0, newWidth, newHeight));
            }
            return newImage;
        }

        public static Image ResizeePercent(Image imgSource, int Percent)
        {
            Image result;
            int yeniWidth = imgSource.Width * Percent / 100;
            int yeniHeight = imgSource.Height * Percent / 100;
            result = new Bitmap(imgSource, new Size(yeniWidth, yeniHeight));
            
           

           
            //***************
            //Bitmap bmPhoto = new Bitmap(yeniWidth, yeniHeight, PixelFormat.Format24bppRgb);
            //bmPhoto.SetResolution(imgSource.HorizontalResolution, imgPhoto.VerticalResolution);

            //Graphics grPhoto = Graphics.FromImage(bmPhoto);
            //grPhoto.InterpolationMode = InterpolationMode.HighQualityBicubic;

            //grPhoto.DrawImage(imgSource,
            //    new Rectangle(yeniWidth, yeniHeight, y, destHeight),
            //    new Rectangle(sourceX, sourceY, sourceWidth, sourceHeight),
            //    GraphicsUnit.Pixel);

            //grPhoto.Dispose();
            //return bmPhoto;

            //*****************

            return result;

        }

        public static Image ToTumbNail(Image imgSource, int width, int height)
        {
            Image result=imgSource;
            if (imgSource.Height <= height && imgSource.Width <= width) //Eðer Verilen Alana Sýðýyorsa Olduðu Gibi Býrak
            {
                return imgSource;
            }
            else if (imgSource.Height <= height && imgSource.Width > width) //Width Sýðmýyorsa
            {
                decimal oranti = 1;
                if (imgSource.Height > imgSource.Width) { oranti = (decimal)imgSource.Height / (decimal)imgSource.Width; } else { oranti = (decimal)imgSource.Width / (decimal)imgSource.Height; }

                int yeniWidth = width;
                int yeniHeight = Convert.ToInt32(width * oranti);
                result = new Bitmap(imgSource, new Size(yeniWidth,yeniHeight));

            }
            else if (imgSource.Height > height && imgSource.Height <= width) //Heigth Sýðmýyorsa
            {
                decimal oranti = 1;
                if (imgSource.Height > imgSource.Width) { oranti = (decimal)imgSource.Height / (decimal)imgSource.Width; } else { oranti = (decimal)imgSource.Width / (decimal)imgSource.Height; }
                int yeniHeight = height;
                int yeniWidth = Convert.ToInt32(height * oranti);
                result = new Bitmap(imgSource, new Size(yeniWidth, yeniHeight));
            }
            else if (imgSource.Height > height && imgSource.Width > width) //Hem Heigth hem Width Sýðmýyorsa
            {
                decimal oranti = 1;  //Orantý Default olarak 1 set edilir

                //Orantý + çýkacak þekilde hesaplanýr
                if (imgSource.Height > imgSource.Width) { oranti = (decimal)imgSource.Height / (decimal)imgSource.Width; } else { oranti = (decimal)imgSource.Width / (decimal)imgSource.Height; }

                //Resmin Height deðeri Yerleþtirilecek alanýn Height deðerine sabitlenir
                int yeniHeight = height;
                int yeniWidth = width;
                if (imgSource.Width > imgSource.Height) //Yatay Resim ise
                {
                    yeniWidth = Convert.ToInt32(imgSource.Width * oranti);
                }
                else if (imgSource.Width < imgSource.Height) //dikey Resim ise
                {
                    yeniWidth = Convert.ToInt32(imgSource.Width / oranti);
                }
                

                while (yeniHeight > height || yeniWidth > width)
                {
                    yeniHeight = yeniHeight - 1;
                    if (imgSource.Width > imgSource.Height) //Yatay Resim ise
                    {
                        yeniWidth = Convert.ToInt32(yeniHeight  * oranti);
                    }
                    else if (imgSource.Width < imgSource.Height) //dikey Resim ise
                    {
                        yeniWidth = Convert.ToInt32(yeniHeight / oranti);
                    }
                    else
                    {
                        yeniWidth = yeniHeight;
                    }
                }
                if (yeniWidth <= 0) { yeniWidth = 1; }
                if (yeniHeight <= 0) { yeniHeight = 1; }
                result = new Bitmap(imgSource, new Size(yeniWidth, yeniHeight));
            }

            return result;
        }

        public static Image Rotate90R(Image imgSource)
        {
            imgSource.RotateFlip(RotateFlipType.Rotate90FlipNone);
            return imgSource;
        }

        public static Image Rotate90L(Image imgSource)
        {
            imgSource.RotateFlip(RotateFlipType.Rotate270FlipNone);
            return imgSource;
        }

        public static ImageSize GetSizeByRatio(int limitWidth, int limitHeight, decimal ratio)
        {
            decimal imgwidth = 0;
            decimal imgheight = 0;
            if (ratio > 0) //Width Büyük
            {
                imgwidth = limitWidth;

                imgheight = (int)(limitWidth / ratio);
                if (imgheight > limitHeight)
                {
                    imgheight = limitHeight;
                    imgwidth = (int)(limitHeight * ratio);
                }
            }
            else if (ratio < 0) //Heigth Büyük
            {
                imgheight = limitHeight;
                imgwidth = (int)(limitHeight * ratio);
                if (imgwidth > limitWidth)
                {
                    imgwidth = limitWidth;
                    imgheight = (int)(limitWidth * ratio);
                }
            }
            else //Eþit
            {
                if (limitHeight > limitWidth)
                {
                    imgheight = limitWidth;
                    imgwidth = limitWidth;
                }
                else if (limitWidth > limitHeight ||limitWidth == limitHeight)
                {
                    imgheight = limitHeight;
                    imgwidth = limitHeight;
                }
            }

            ImageSize sonuc = new ImageSize();
            sonuc.Width = (int)imgwidth;
            sonuc.Height = (int)imgheight;
            return sonuc;
        }
	}

    public class ImageSize
    {
        public int Width { get; set; }
        public int Height { get; set; }
    }

