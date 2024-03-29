﻿using System.Numerics;

namespace _3DPixelArtEngine
{
    public class Vector : Ray
    {
        public float Length;
        public Vector3 Displacement
        {
            get => Direction * Length;
        }

        public Vector(Vector3 origin, Vector3 rotation, float length) : base(origin, rotation)
        {
            Length = length;
        }

        public Vector(Vector3 start, Vector3 end) : base(start, Vector3.Normalize(end - start))
        {
            Length = Vector3.Distance(start, end);
        }
    }
}
