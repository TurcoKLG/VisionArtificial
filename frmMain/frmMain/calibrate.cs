using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using System.Windows.Forms;
using Emgu.CV.UI;
using Emgu.CV.Structure;
using System.Drawing;

namespace frmMain
{
    class calibrate
    {
        const int width = 9;//9 //width of chessboard no. squares in width - 1
        const int height = 6;//6 // heght of chess board no. squares in heigth - 1
        Size patternSize = new Size(width, height); //size of chess board to be detected
        Bgr[] line_colour_array = new Bgr[width * height]; // just for displaying coloured lines of detected chessboard

        static int buffer_length;
        MCvPoint3D32f[][] corners_object_Points = new MCvPoint3D32f[buffer_length][]; //stores the calculated size for the chessboard
        PointF[][] corners_points_Left = new PointF[buffer_length][];//stores the calculated points from chessboard detection Camera 1
        PointF[][] corners_points_Right = new PointF[buffer_length][];//stores the calculated points from chessboard detection Camera 2

        IntrinsicCameraParameters IntrinsicCam1 = new IntrinsicCameraParameters();
        IntrinsicCameraParameters IntrinsicCam2 = new IntrinsicCameraParameters();
        ExtrinsicCameraParameters EX_Param;

        Matrix<double> fundamental; //fundemental output matrix for StereoCalibrate
        Matrix<double> essential; //essential output matrix for StereoCalibrate
        Rectangle Rec1 = new Rectangle(); //Rectangle Calibrated in camera 1
        Rectangle Rec2 = new Rectangle(); //Rectangle Caliubrated in camera 2
        Matrix<double> Q = new Matrix<double>(4, 4); //This is what were interested in the disparity-to-depth mapping matrix
        Matrix<double> R1 = new Matrix<double>(3, 3); //rectification transforms (rotation matrices) for Camera 1.
        Matrix<double> R2 = new Matrix<double>(3, 3); //rectification transforms (rotation matrices) for Camera 1.
        Matrix<double> P1 = new Matrix<double>(3, 4); //projection matrices in the new (rectified) coordinate systems for Camera 1.
        Matrix<double> P2 = new Matrix<double>(3, 4); //projection matrices in the new (rectified) coordinate systems for Camera 2.
        private MCvPoint3D32f[] _points; //Computer3DPointsFromStereoPair

        public void StartCalib(Mat frame_S1)
        {
                //fill the MCvPoint3D32f with correct mesurments
                for (int k = 0; k < buffer_length; k++)
                {
                    //Fill our objects list with the real world mesurments for the intrinsic calculations
                    List<MCvPoint3D32f> object_list = new List<MCvPoint3D32f>();
                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            object_list.Add(new MCvPoint3D32f(j * 20.0F, i * 20.0F, 0.0F));
                        }
                    }
                    corners_object_Points[k] = object_list.ToArray();
                }
                //If Emgu.CV.CvEnum.CALIB_TYPE == CV_CALIB_USE_INTRINSIC_GUESS and/or CV_CALIB_FIX_ASPECT_RATIO are specified, some or all of fx, fy, cx, cy must be initialized before calling the function
                //if you use FIX_ASPECT_RATIO and FIX_FOCAL_LEGNTH options, these values needs to be set in the intrinsic parameters before the CalibrateCamera function is called. Otherwise 0 values are used as default.
                CvInvoke.StereoCalibrate(corners_object_Points, corners_points_Left, corners_points_Right, IntrinsicCam1.IntrinsicMatrix, IntrinsicCam1.DistortionCoeffs, 
                    IntrinsicCam2.IntrinsicMatrix, IntrinsicCam2.DistortionCoeffs, frame_S1.Size,
                    EX_Param.RotationVector.RotationMatrix,EX_Param.TranslationVector, essential, fundamental,  
                    Emgu.CV.CvEnum.CalibType.Default, new MCvTermCriteria(0.1e5));
                MessageBox.Show("Intrinsci Calculation Complete"); //display that the mothod has been succesful
                //currentMode = Mode.Calibrated;

                //Computes rectification transforms for each head of a calibrated stereo camera.
                CvInvoke.StereoRectify(IntrinsicCam1.IntrinsicMatrix, IntrinsicCam2.IntrinsicMatrix,
                                         IntrinsicCam1.DistortionCoeffs, IntrinsicCam2.DistortionCoeffs,
                                         frame_S1.Size,
                                         EX_Param.RotationVector.RotationMatrix, EX_Param.TranslationVector,
                                         R1, R2, P1, P2, Q,
                                         Emgu.CV.CvEnum.StereoRectifyType.Default, 0,
                                         frame_S1.Size, ref Rec1, ref Rec2);

                //This will Show us the usable area from each camera
                MessageBox.Show("Left: " + Rec1.ToString() + " \nRight: " + Rec2.ToString());

            
        }


    }
}
