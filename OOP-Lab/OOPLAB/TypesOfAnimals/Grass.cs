namespace OOPLAB;

class Grass : GameObject
{
    public bool IsGrown { get; private set; }
    private int _growRate;

    public Grass()
    {
        Saturability = 1;
        IsGrown = true;
        _growRate = 10;
        Simulation.Update += Grow;
    }

    public void Eaten()
    {
        IsGrown = false;
        _growRate = 0;
    }

    private void Grow()
    {
        if (IsGrown == false)
        {
            _growRate++;
            if (_growRate == 10)
            {
                IsGrown = true;
            }
        }
    }
}

