using System;
using System.Text;
using System.Collections.Generic;

namespace RemoteTech
{
    static public class Common {

        static public long Now() {
            return GetGameTime();
        }

        static public long GetGameTime() {
            return (long)(Planetarium.GetUniversalTime() * 1000);
        }

        static public String GetAnimationArrows() {
            switch ((long)Planetarium.GetUniversalTime() % 4) {
                default:
                case 0:
                    return "";
                case 1:
                    return "»";
                case 2:
                    return "»»";
                case 3:
                    return "»»»";
            }
        }

        static public String FormatTime(long time) {
            if (time < 0) {
                return "";
            }

            StringBuilder result = new StringBuilder();
            long seconds = time / 1000;
            long minutes = Math.DivRem(seconds, 60, out seconds);
            long hours = Math.DivRem(minutes, 60, out minutes);
            long days = Math.DivRem(hours, 24, out hours);

            if (days > 0) {
                result.Append(days + "d");
            }
            if (hours > 0) {
                result.Append(hours + "h");
            }
            if (minutes > 0) {
                result.Append(minutes + "m");
            }
            if (seconds > 0) {
                result.Append(seconds + "s");
            }

            return result.ToString();
        }

        static public long ReverseFormatTime(int days, int hours, int minutes, int seconds) {
            return 1000 * (seconds + 60 * (minutes + 60 * (hours + 24 * days)));
        }

        static public readonly Dictionary<String, String> PlanetColourMap = new Dictionary<String, String> {
            { "Kerbin", "blue" }, { "Mün", "grey" }, { "Minmus", "cyan" }, { "Duna", "orange" }, { "Eve", "purple" },
            { "Jool", "green" }, { null, "grey" },
        };
    }




}

