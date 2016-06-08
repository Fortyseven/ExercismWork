using System;

internal class SpaceAge
{
    private const float EARTH_BASE_SECS = 31557600.0f;

    private const float MULT_MERCURY = 0.2408467f;
    private const float MULT_VENUS = 0.61519726f;
    private const float MULT_MARS = 1.8808158f;
    private const float MULT_JUPITER = 11.862615f;
    private const float MULT_SATURN = 29.447498f;
    private const float MULT_URANUS = 84.016846f;
    private const float MULT_NEPTUNE = 164.79132f;

    public float Seconds { get; private set; }

    public SpaceAge(float age_in_seconds)
    {
        this.Seconds = age_in_seconds;
    }

    public float OnEarth()
    {
        return Seconds / EARTH_BASE_SECS;
    }

    public float OnVenus()
    {
        return (Seconds / (EARTH_BASE_SECS * MULT_VENUS));
    }

    public float OnMercury()
    {
        return (Seconds / (EARTH_BASE_SECS * MULT_MERCURY));
    }

    public float OnMars()
    {
        return (Seconds / (EARTH_BASE_SECS * MULT_MARS));
    }

    public float OnJupiter()
    {
        return (Seconds / (EARTH_BASE_SECS * MULT_JUPITER));
    }

    public float OnSaturn()
    {
        return (Seconds / (EARTH_BASE_SECS * MULT_SATURN));
    }

    public float OnUranus()
    {
        return (Seconds / (EARTH_BASE_SECS * MULT_URANUS));
    }

    public float OnNeptune()
    {
        return (Seconds / (EARTH_BASE_SECS * MULT_NEPTUNE));
    }
}