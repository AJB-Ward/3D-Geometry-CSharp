using System;

namespace _3D_Geometry_CSharp
{
    public class Vector3
    {
        double[] m_Coordinates;

        public Vector3(double x, double y, double z)
        {
            m_Coordinates = new double[]{x,y,z};
        }

        public double[] GetValue()
        {
            return m_Coordinates;
        }

    }
}