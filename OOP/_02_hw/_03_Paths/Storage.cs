using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Point3D;
using System.IO;

namespace _03_Paths
{
    static class Storage
    {
        static private int savedPathsCounter = 0;
        static public void Save(Path3D path, string filePath)
        {
            string spoints = "";
            for (int i = 0; i < path.Points.Count; i++)
            {
                spoints += path.Points[i].X + "," + path.Points[i].Y + "," + path.Points[i].Z + "/";
            }
            spoints = spoints.Substring(0, spoints.Length - 1);
            string filePathPlusName = filePath + "filePath" + savedPathsCounter + ".txt";
            if (!File.Exists(filePathPlusName))
            {
                using (StreamWriter sw = File.CreateText(filePathPlusName))
                {
                    sw.WriteLine(spoints);
                    Storage.savedPathsCounter++;
                    sw.Close();
                }
            }
            else
            {
                StreamWriter sw = new StreamWriter(filePathPlusName);
                sw.WriteLine(spoints);
                Storage.savedPathsCounter++;
                sw.Close();
            }
        }
        static public List<Point3D> Load(string file)
        {
            string spoint = "";
            using (StreamReader sr = File.OpenText(file))
            {
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    spoint += line;
                    line = sr.ReadLine();
                }
            }
            Point3D pN;
            List<string> coords;
            List<string> spoints = spoint.Split('/').ToList<string>();
            List<Point3D> path = new List<Point3D>();
            foreach (string point in spoints)
            {
                coords = point.Split(',').ToList<string>();
                pN = new Point3D(int.Parse(coords[0]), int.Parse(coords[1]), int.Parse(coords[2]));
                path.Add(pN);
            }
            return path;
        }
    }
}
