using System.Drawing;

namespace OOPLAB
{
    abstract class Animals : ObjectWhoCanLookAround
    {
        public int HungerLevel { get; set; }
        public Animals()
        {
            Simulation.Move += Move;
        }

        private void AnimalAction(List<GameObject>[,] map)
        {
            if (Satiety == MaxSatiety && target.GetType() == this.GetType())
                PairingAnimals(map);
            else
                Eat(map);
        }
        public void Move(List<GameObject>[,] map)
        {
            if(target is not null) Console.Write("+");
            if (!map[Coordinate.X, Coordinate.Y].Contains(this))
                return;
   
            ICheckTarget CheckPredators = new CheckTargetForPredators();
            ICheckTarget CheckPreys = new CheckTargetForPreys();
            if (this is Preys)
                CheckFieldOfView(map, CheckPreys.CheckTarget);
            else
                CheckFieldOfView(map, CheckPredators.CheckTarget);

            Point newCoordinate;
            var movedObject = ActionsOnMap.DeleteObject(map, this);

            if (target is not null)
                newCoordinate = TargetMovement();
            else
            {
                var random = Direction.RandomDirection();
                newCoordinate = random;
                newCoordinate += new Size(Coordinate.X, Coordinate.Y);
                if (!InsideBound(newCoordinate, map))
                    newCoordinate = Direction.ChangeDirection(newCoordinate, map);
            }

            ActionsOnMap.AddObject(newCoordinate, map, this);
            if (target is not null && newCoordinate == target.Coordinate)
                AnimalAction(map);
        }
    }
}
