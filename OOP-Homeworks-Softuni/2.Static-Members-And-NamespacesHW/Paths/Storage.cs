using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Paths
{
    class Storage
    {
        public static void SavePathToFile(string filePath, string path)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine(path);
            }
        }

        public static Path LoadPathFromFile(string filepath)
        {
            
            Path path = new Path();

            using (StreamReader reader = new StreamReader(filepath))
            {
                string line = reader.ReadLine();
                const string PointPattern = @"[xyz=:\-\s](\d+(?:(?:\.|,)\d+)*)";

                while (line != null)
                {
                    MatchCollection matches = Regex.Matches(line, PointPattern);
                    if (matches.Count == 3)
                    {
                        double x = double.Parse(matches[0].Groups[1].Value);
                        double y = double.Parse(matches[1].Groups[1].Value);
                        double z = double.Parse(matches[2].Groups[1].Value);

                        Point3D point = new Point3D(x, y, z);
                    
                    }

                    line = reader.ReadLine();
                }
            }
            return path;
        }
    }
}