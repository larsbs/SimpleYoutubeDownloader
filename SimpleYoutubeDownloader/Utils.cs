using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleYoutubeDownloader
{
    class Utils
    {
        public static string ParseArguments(string audioFormat, string videoFormat, string quality)
        {
            string audioQuality = "0";
            string videoQuality = "";
            switch (quality)
            {
                case "Low Quality":
                    audioQuality = "5";
                    switch (videoFormat)
                    {
                        case "flv":
                            videoQuality = "5";
                            break;
                        case "3gp":
                            videoQuality = "17";
                            break;
                        default:
                            videoQuality = "18";
                            break;
                    }
                    break;
                case "Mid Quality":
                    audioQuality = "3";
                    switch (videoFormat)
                    {
                        case "flv":
                            videoQuality = "34/5";
                            break;
                        case "3gp":
                            videoQuality = "36/17";
                            break;
                        default:
                            videoQuality = "22/18";
                            break;
                    }
                    break;
                default:
                    audioQuality = "0";
                    switch (videoFormat)
                    {
                        case "flv":
                            videoQuality = "35/34/5";
                            break;
                        case "3gp":
                            videoQuality = "36/17";
                            break;
                        default:
                            videoQuality = "22/18";
                            break;
                    }
                    break;
            }

            return @"-x -k --audio-format " + audioFormat + " --audio-quality " + audioQuality + " -f " + videoQuality;
        }
    }
}
