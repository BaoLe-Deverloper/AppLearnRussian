using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AppLearnRussian
{
    public static class Mp3Player
    {

        [DllImport("winmm.dll")]
        private static extern long mciSendString(string lpstrCommand, StringBuilder lpstrReturnString, int uReturnLength, int hwdCallBack);

        public static void open(string File)
        {
            string Format = @"open ""{0}"" type MPEGVideo alias MediaFile";

            string command = string.Format(Format, File);
            mciSendString(command, null, 0, 0);
        }

        public static void play()
        {
            string command = "play MediaFile";
            mciSendString(command, null, 0, 0);
        }
        public static void stop()
        {
            string command = "stop MediaFile";
            mciSendString(command, null, 0, 0);
        }
        public static void Volume(int volumeValue)

        {
            string cmd = String.Format("setaudio MediaFile volume to {0}", volumeValue);
            mciSendString(cmd, null, 0, 0);


        }
        public static void Exit()

        {
            string cmd = String.Format("close MediaFile");
            mciSendString(cmd, null, 0, 0);

        }
        public static void Pause()

        {
            string cmd = String.Format("pause MediaFile");
            mciSendString(cmd, null, 0, 0);

        }

    }

}
