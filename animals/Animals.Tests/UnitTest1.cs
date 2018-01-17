using System;
using Xunit;

namespace Animals.Tests
{
    public class AnimalShould
    {
        private Animal _animal;
        private Dog _doggo;

        public AnimalShould()
        {
            _animal = new Animal();
            _doggo = new Dog();
        }

        [Fact]
        public void SetNameMethod()
        {
            _animal.SetName("Frederick");
            Assert.Equal(_animal.Name, "Frederick");

            _doggo.SetName("Lando");
            Assert.Equal(_doggo.Name, "Lando");
            
        }

        [Fact]
        public void SetSpeciesMethod()
        {
            // Setting the species will be defined on Animal class
            _animal.SetSpecies("Elephant");
            Assert.Equal(_animal.Species, "Elephant");

            _doggo.SetSpecies("Pomeranian-Pekingese");
            Assert.Equal(_doggo.Species, "Pomeranian-Pekingese");

        }

        [Fact]
        public void SetWalkingSpeedMethod()
        {
            _animal.Walk(2);
            Assert.Equal(_animal.WalkingSpeed, 4);

            _doggo.Walk(1);
            Assert.Equal(_doggo.WalkingSpeed, 2);
        }

        [Fact]
        public void InstanceShouldBeOfCorrectType()
        {
            Assert.IsType<Animal>(_animal);
            Assert.IsType<Dog>(_doggo);
        }
    }
}