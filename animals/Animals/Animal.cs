namespace Animals
{
  public class Animal
  {
    private string _name;
    private string _species;
    private double _walkingSpeed;

    public string Name {get {return _name;}}

    public string Species {get {return _species;}}

    public double WalkingSpeed{get {return _walkingSpeed;}}

    public void SetName(string name)
    {
        _name = name;
    }

    public void SetSpecies(string species)
    {
      _species = species;
    }

    public void Walk(double speed)
    {
      _walkingSpeed = (speed * 2);
    }
  }
}