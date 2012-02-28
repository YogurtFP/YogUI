using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using Microsoft.Xna.Framework;
namespace YogUILibrary.Managers
{
    public static class ConversionManager
    {

        public static string GetSafeName(string path)
        {
            Regex r = new Regex("(.+?\\\\)+(.+?)\\.(?=.+)");
            Match mc = r.Match(path);
            return mc.Groups[2].Value;
        }

        public static TimeSpan FloatToTime(float minutes)
        {
            double seconds = minutes * 60;
            return TimeSpan.FromSeconds(seconds);
        }

        public static double DegreeToRadians(double degree)
        {
            return degree * (Math.PI / 180);
        }

        public static double circleTo360(double degrees)
        {
            if (degrees < 0)
            {
                degrees = 360 + degrees;
            }
            return degrees;
        }

        public static double circleTo180(double degrees)
        {
            if (degrees > 180)
            {
                degrees = 180 - degrees;
            }
            return degrees;
        }

        public static double RadianToDegrees(double radian)
        {
            return radian * (180 / Math.PI);
        }

        public static Vector2 PToV(Point p)
        {
            return new Vector2(p.X, p.Y);
        }

        public static Point VToP(Vector2 v)
        {
            return new Point((int)v.X, (int)v.Y);
        }

        private static float _displayUnitsToSimUnitsRatio = 100f;
        private static float _simUnitsToDisplayUnitsRatio = 1 / _displayUnitsToSimUnitsRatio;

        public static void SetDisplayUnitToSimUnitRatio(float displayUnitsPerSimUnit)
        {
            _displayUnitsToSimUnitsRatio = displayUnitsPerSimUnit;
            _simUnitsToDisplayUnitsRatio = 1 / displayUnitsPerSimUnit;
        }

        public static float ToDisplayUnits(float simUnits)
        {
            return simUnits * _displayUnitsToSimUnitsRatio;
        }

        public static float ToDisplayUnits(int simUnits)
        {
            return simUnits * _displayUnitsToSimUnitsRatio;
        }

        public static Vector2 ToDisplayUnits(Vector2 simUnits)
        {
            return simUnits * _displayUnitsToSimUnitsRatio;
        }

        public static void ToDisplayUnits(ref Vector2 simUnits, out Vector2 displayUnits)
        {
            Vector2.Multiply(ref simUnits, _displayUnitsToSimUnitsRatio, out displayUnits);
        }

        public static Vector3 ToDisplayUnits(Vector3 simUnits)
        {
            return simUnits * _displayUnitsToSimUnitsRatio;
        }

        public static Vector2 ToDisplayUnits(float x, float y)
        {
            return new Vector2(x, y) * _displayUnitsToSimUnitsRatio;
        }

        public static void ToDisplayUnits(float x, float y, out Vector2 displayUnits)
        {
            displayUnits = Vector2.Zero;
            displayUnits.X = x * _displayUnitsToSimUnitsRatio;
            displayUnits.Y = y * _displayUnitsToSimUnitsRatio;
        }

        public static float ToSimUnits(float displayUnits)
        {
            return displayUnits * _simUnitsToDisplayUnitsRatio;
        }

        public static float ToSimUnits(double displayUnits)
        {
            return (float)displayUnits * _simUnitsToDisplayUnitsRatio;
        }

        public static float ToSimUnits(int displayUnits)
        {
            return displayUnits * _simUnitsToDisplayUnitsRatio;
        }

        public static Vector2 ToSimUnits(Vector2 displayUnits)
        {
            return displayUnits * _simUnitsToDisplayUnitsRatio;
        }

        public static Vector3 ToSimUnits(Vector3 displayUnits)
        {
            return displayUnits * _simUnitsToDisplayUnitsRatio;
        }

        public static void ToSimUnits(ref Vector2 displayUnits, out Vector2 simUnits)
        {
            Vector2.Multiply(ref displayUnits, _simUnitsToDisplayUnitsRatio, out simUnits);
        }

        public static Vector2 ToSimUnits(float x, float y)
        {
            return new Vector2(x, y) * _simUnitsToDisplayUnitsRatio;
        }

        public static Vector2 ToSimUnits(double x, double y)
        {
            return new Vector2((float)x, (float)y) * _simUnitsToDisplayUnitsRatio;
        }

        public static void ToSimUnits(float x, float y, out Vector2 simUnits)
        {
            simUnits = Vector2.Zero;
            simUnits.X = x * _simUnitsToDisplayUnitsRatio;
            simUnits.Y = y * _simUnitsToDisplayUnitsRatio;
        }

    }
}
