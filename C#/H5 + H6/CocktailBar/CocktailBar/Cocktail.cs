using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailBar
{
    internal class Cocktail
    {
        private String _naam;
        private decimal _kostPrijs;
        private List <Ingredient> _ingredienten;

        public Cocktail(String naam, decimal kostPrijs)
        {
            _naam = naam;
            _kostPrijs = kostPrijs;
            _ingredienten = new List<Ingredient>();
        }
        public String Naam
        {
            get { return _naam; }
            set { _naam = value; }
        }
        public decimal KostPrijs
        {
            get { return _kostPrijs; }
            set { _kostPrijs = value; }
        }
        public List<Ingredient> Ingredienten
        {
            //get { return new List<Ingredient>(_ingredienten); }
            get { return _ingredienten; }
        }
        public void VoegIngredientToe(Ingredient ingredient)
        {
            _ingredienten.Add(ingredient);
        }
        public int HoeveelIngredienten()
        {
            return _ingredienten.Count;
        }
        public int InhoudCocktail()
        {
            // som van alle hoeveelheden van de ingrediënten
            int totaal = 0;
            foreach (Ingredient ingr in _ingredienten)
            {
                totaal += ingr.Hoeveelheid;
            }
            return totaal;
        }
        public int HoeveelAlcoholischeIngredienten()
        {
            // tel het aantal ingrediënten waarvoor Ingredient.IsAlcoholisch() true is
            int totaal = 0;
            foreach (Ingredient ingr in _ingredienten)
            {
                if (ingr.IsAlcoholisch())
                    totaal++;
            }
            return totaal;
        }
        public bool IsAlcoholisch()
        {
            // gebruik hulpmethode HoeveelAlcoholischeIngredienten()
            // retourneer true wanneer er minstens één alcoholisch ingrediënt is
            return HoeveelAlcoholischeIngredienten() > 0;
        }
        public string AlleIngredienten()
        {
            // retourneer een puntkomma-gescheiden string zoals:
            // "100 ml cola; 50 ml rum; ..."
            String ingredienten = "";
            foreach (Ingredient ingr in _ingredienten)
            {
                ingredienten += $"{ingr.Hoeveelheid} ml {ingr.Naam}; ";
            }
            return ingredienten;
        }
        public Ingredient GeefIngredient(int index)
        {
            // retourneer het ingrediënt op positie index of null bij ongeldige index
            if (index >= 0 && index < _ingredienten.Count)
            { return _ingredienten[index]; }
            else { return null; }
        }
        public string GeefNaamIngredient(int index)
        {
            // retourneer de naam van het ingrediënt op index of "#Fout" bij ongeldige index
            if (index >= 0 && index < _ingredienten.Count)
                return _ingredienten[index].Naam;
            else
                return "#Fout";
        }
        public void VerwijderIngredient(int index)
        {
            // verwijder ingrediënt op index, controleer geldige index
            if (index >= 0 && index < _ingredienten.Count)
            {
                _ingredienten.RemoveAt(index);
            }
        }
        public void MaakAlcoholvrij(decimal nieuwePrijs)
        {
            // Verwijder ALLE alcoholische ingrediënten (gebruik FOR-lus!)
            // Voeg " - alcoholvrij" toe aan de naam
            // Zet KostPrijs = nieuwePrijs
            for (int i = _ingredienten.Count - 1; i >= 0; i--)
            {
                if (_ingredienten[i].IsAlcoholisch())
                {
                    _ingredienten.RemoveAt(i);
                }
            }
            _naam += " - alcoholvrij";
            _kostPrijs = nieuwePrijs;

        }
        public double Alcoholpercentage()
        {
            // bereken totale pure alcohol (som van hoeveelheid * alcoholpercentage)
            // en deel door totale inhoud; retourneer percentage (0..100)
            int totaalInhoud = InhoudCocktail();
            if (totaalInhoud == 0)
            {
                return 0;
            }

            double totaleAlcoholPercentage = 0;
            foreach (Ingredient ingr in _ingredienten)
            {
                totaleAlcoholPercentage += ingr.Hoeveelheid * ingr.Alcoholpercentage;
            }
            return (totaleAlcoholPercentage / totaalInhoud) *100;
        }

        public List<Ingredient> AlcoholischeIngredienten()
        {
            List<Ingredient> alcoholisch = new List<Ingredient>();
            foreach (Ingredient ingr in _ingredienten)
            {
                if (ingr.IsAlcoholisch())
                {
                    alcoholisch.Add(ingr);
                }
            }
            return alcoholisch;
        }
        public List<Ingredient> NietAlcoholischeIngredienten()
        {
            List<Ingredient> nonAlcoholisch = new List<Ingredient>();
            foreach (Ingredient ingr in _ingredienten)
            {
                if (!ingr.IsAlcoholisch())
                {
                    nonAlcoholisch.Add(ingr);
                }
            }
            return nonAlcoholisch;
        }
    }
}
