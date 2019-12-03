using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;

namespace Trestlebridge.Models.Facilities
{
    public class GrazingField : IFacility<IGrazing>
    {
        private int _capacity = 50;
        private Guid _id = Guid.NewGuid();

        private List<IGrazing> _animals = new List<IGrazing>();

        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }

        public void AddResource(IGrazing animal)
        {
            // TODO: implement this...

            _animals.Add(animal);

        }

        public void AddResource(List<IGrazing> animals)
        {
            // TODO: implement this...

        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Grazing field {shortId} has {this._animals.Count} animals\n");
            this._animals.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }

        public double GetCount
        {
            get
            {
                return _animals.Count;
            }
        }

        public void listAnimals(){
            var cowSortedList = _animals.Where(cow => cow.returnAnimalType == "Cow");
            Console.Write($"Cows: {cowSortedList.Count()}") ;

            var sheepSortedList = _animals.Where(sheep => sheep.returnAnimalType == "Sheep");
            Console.Write($" Sheep: {sheepSortedList.Count()}" );

            var ostrichSortedList = _animals.Where(ostrich => ostrich.returnAnimalType == "Ostrich");
            Console.Write($" Ostriches: {ostrichSortedList.Count()}" );

            var goatSortedList = _animals.Where(goat => goat.returnAnimalType == "Goat");
            Console.Write($" Goats: {goatSortedList.Count()}" );

            var pigSortedList = _animals.Where(pig => pig.returnAnimalType == "Pig");
            Console.Write($" Pigs: {pigSortedList.Count()}");
        }
    }
}