using System;

public enum TriangleKind { Equilateral, Isosceles, Scalene }

public class TriangleException : Exception { }

public class Triangle
{
    public static TriangleKind Kind( int v1, int v2, int v3 )
    {
        return Kind( (decimal)v1, (decimal)v2, (decimal)v3 );
    }

    public static TriangleKind Kind( decimal v1, decimal v2, decimal v3 )
    {
        // negatives
        if ( ( v1 <= 0 ) || ( v2 <= 0 ) || ( v3 <= 0 ) )
            throw new TriangleException();

        // inequality
        if ( ( v1 + v3 <= v2 ) || ( ( v1 + v2 ) <= v3 ) || ( ( v2 + v3 ) <= v1 ) ) {
            throw new TriangleException();
        }

        if ( v1.Equals( v2 ) && v2.Equals( v3 ) ) {
            return TriangleKind.Equilateral;
        }

        if ( v1.Equals( v2 ) || v2.Equals( v3 ) || v1.Equals( v3 ) ) {
            return TriangleKind.Isosceles;
        }

        return TriangleKind.Scalene;
    }
}