using Rando;
using System;
using System.Collections.Generic;
using System.Xml;
class Reader
{
    public static List<Trackpoint> ReadGpxFile(string filePath)
    {
        var trackpoints = new List<Trackpoint>();
        XmlDocument doc = new XmlDocument();
        doc.Load(filePath);

        XmlNamespaceManager ns = new XmlNamespaceManager(doc.NameTable);
        ns.AddNamespace("default", "http://www.topografix.com/GPX/1/1");
        XmlNodeList nodes = doc.SelectNodes("//default:trkpt", ns);

        foreach (XmlNode node in nodes)
        {
            double lat = double.Parse(node.Attributes["lat"].Value);
            double lon = double.Parse(node.Attributes["lon"].Value);
            double ele = 0;

            /*
             * If ele, exists get it 
             */
            var eleNode = node.SelectSingleNode("default:ele", ns);
            if (eleNode != null)
            {
                double.TryParse(eleNode.InnerText, out ele);
            }

            var trackpoint = new Trackpoint(lat, lon, ele);
            trackpoints.Add(trackpoint);
        }

        return trackpoints;
    }
}