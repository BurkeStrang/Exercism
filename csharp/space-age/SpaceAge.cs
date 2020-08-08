using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Utilities;

/*
- Earth: orbital period 365.25 Earth days, or 31557600 seconds
- Mercury: orbital period 0.2408467 Earth years
- Venus: orbital period 0.61519726 Earth years
- Mars: orbital period 1.8808158 Earth years
- Jupiter: orbital period 11.862615 Earth years
- Saturn: orbital period 29.447498 Earth years
- Uranus: orbital period 84.016846 Earth years
- Neptune: orbital period 164.79132 Earth years
 * */
public class SpaceAge
{
    private readonly long _seconds;

    private Dictionary<string, double> _plantYearRate = new Dictionary<string, double>
    {
        {"Earth", 1},
        {"Mercury", 0.2408467},
        {"Venus", 0.61519726},
        {"Mars", 1.8808158},
        {"Jupiter", 11.862615},
        {"Saturn", 29.447498},
        {"Uranus", 84.016846},
        {"Neptune", 164.79132},
    };

    private double _secondOfOneEarthYear = 31557600;


    public SpaceAge(long seconds) => _seconds = seconds;
    

    public double OnEarth() => On("Earth");

    public double OnMercury() => On("Mercury");

    public double OnVenus() => On("Venus");

    public double OnMars() => On("Mars");

    public double OnJupiter() => On("Jupiter");

    public double OnSaturn() => On("Saturn");

    public double OnUranus() => On("Uranus");

    public double OnNeptune() => On("Neptune");

    private double On(string plant)
    {
        return Math.Round(_seconds / (_plantYearRate[plant] * _secondOfOneEarthYear), 2);
    }
}