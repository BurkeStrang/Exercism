using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;


public enum Allergen : int
{
    Eggs = 1,
    Peanuts = 2,
    Shellfish = 4,
    Strawberries = 8,
    Tomatoes = 16,
    Chocolate = 32,
    Pollen = 64,
    Cats = 128
}

public class Allergies
{
    private readonly List<Allergen> _ListAllergens;

    public Allergies(int mask) =>
        _ListAllergens = new List<Allergen>(Enum.GetValues(typeof(Allergen)).Cast<Allergen>())
            .Where(a => a != 0 && (a & (Allergen) mask) == a).ToList();


    public bool IsAllergicTo(Allergen allergen) => _ListAllergens.Contains(allergen);

    public Allergen[] List() => _ListAllergens.ToArray();

}