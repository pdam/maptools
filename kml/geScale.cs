
/*
 * ge-kml: A .NET 2.0 class library that implements the Google Earth 2.1 API
 * Copyright (C) 2006  Ryan M. Johnston (SourceForge-boseefus00001)
 * Questions, Comments, Praise, and Flame can be sent to ryan-gekml@homieshouse.com
 * 
 * This program is free software; you can redistribute it and/or
 * modify it under the terms of the GNU General Public License
 * as published by the Free Software Foundation; either version 2
 * of the License, or (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
 */

// **** Modification History **** //
/*
 * 2006-12-19: boseefus00001
 *      * Initial release
 * 
 * 2007-05-29: Maksim Sestic
 *      * Updated XML tags
 * 
 * YYYY-MM-DD: <developer>
 *      *  Modification
 * 
 */

using System;
using System.Xml;

namespace Google.KML
{
    /// <summary>
    /// Scales a model along the x, y, and z axes in the model's coordinate space
    /// </summary>
    public class geScale : geObject
    {
        /// <summary>
        /// x axis
        /// </summary>
        public double x;

        /// <summary>
        /// y axis
        /// </summary>
        public double y;

        /// <summary>
        /// z axis
        /// </summary>
        public double z;

        /// <summary>
        /// Renders the object to KML
        /// </summary>
        /// <param name="kml"></param>
        public override void ToKML(XmlTextWriter kml)
        {
            kml.WriteStartElement("Scale");
            kml.WriteElementString("x", x.ToString());
            kml.WriteElementString("y", y.ToString());
            kml.WriteElementString("z", z.ToString());
            kml.WriteEndElement();
           
        }
    }
}
