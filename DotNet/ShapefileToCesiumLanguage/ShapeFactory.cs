﻿using System;
using System.Drawing;
using Shapefile;
using CesiumLanguageWriter;

namespace ShapefileToCesiumLanguage
{
    public class ShapeFactory
    {
        static public CzmlShape Create(Shape shape, CzmlDocument document, Color color)
        {
            switch (shape.ShapeType)
            {
                case ShapeType.Point:
                case ShapeType.PointM:
                    return new Point((PointShape)shape, document, color);
                case ShapeType.PointZ:
                    return new PointZ((PointZShape)shape, document, color);
                case ShapeType.Polyline:
                case ShapeType.PolylineM:
                case ShapeType.PolylineZ:
                    return new Polyline((PolylineShape)shape, document, color);
                case ShapeType.Polygon:
                case ShapeType.PolygonM:
                case ShapeType.PolygonZ:
                    return new Polygon((PolygonShape)shape, document, color);
            }
            throw new NotImplementedException();
        }
    }
}
