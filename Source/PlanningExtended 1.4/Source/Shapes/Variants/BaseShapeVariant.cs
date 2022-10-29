﻿using PlanningExtended.Cells;
using Verse;

namespace PlanningExtended.Shapes.Variants
{
    public abstract class BaseShapeVariant
    {
        public abstract ShapeVariant ShapeVariant { get; }

        public virtual ShapeOptions FirstShapeOption { get; }

        public virtual ShapeOptions SecondShapeOption { get; }

        public int NumberOfAvailableShapeOtions => NumShapeOptions(FirstShapeOption) + NumShapeOptions(SecondShapeOption);

        public abstract bool IsCellValid(IntVec3 cell, AreaDimensions areaDimensions);

        public virtual void Rotate(RotationDirection rotationDirection)
        {

        }

        public virtual void ChangeShapeOption(ShapeOptions shapeOptions, ShapeOptionDirection shapeOptionDirection)
        {

        }

        int NumShapeOptions(ShapeOptions shapeOptions)
        {
            return shapeOptions != ShapeOptions.None ? 1 : 0;
        }
    }
}
