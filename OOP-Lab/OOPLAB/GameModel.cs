using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLAB
{        
    class GameModel
    {
        public List<GameObject>[,] map;
        private int _mapLenght;
        public Random RandomValue = new Random();   
        public GameModel()
        {
            _mapLenght = 64;
            map = new List<GameObject>[_mapLenght, _mapLenght]; 
            for (int i = 0; i < _mapLenght; i++)
                for (int j = 0; j < _mapLenght; j++)
                    map[i, j] = new List<GameObject>();
            GenerateGrass(53, 45); 
            GenerateGrass(30, 24);
            GenerateGrass(8, 47); 
            GenerateGrass(8, 2);
            GenerateGrass(50, 2); 
            GenerateAnimals();                                                       
        }

        private void GenerateAnimals()
        {   
            for (int i = 0; i < _mapLenght; i++)
            {
                    for (int j = 0; j < _mapLenght; j++)
                    {
                    int generationChance = RandomValue.Next(1, 81);     
                        if(generationChance < 5) 
                            switch(GenerateRandPrey()) 
                        {
                        case 1:
                             ActionsOnMap.AddObject(new Point(i, j), map, new Bull());
                             break;
                        case 2:
                             ActionsOnMap.AddObject(new Point(i, j), map, new Cow());
                             break;
                        case 3:
                             ActionsOnMap.AddObject(new Point(i, j), map, new Rabbit());
                             break;                    
                        case 4:
                             ActionsOnMap.AddObject(new Point(i, j), map, new Sheep());
                             break;                          
                        }
                         if(generationChance == 5) switch(GenerateRandPredator()) 
                        {
                        case 5:
                            ActionsOnMap.AddObject(new Point(i, j), map, new Bear()); 
                            break;    
                        case 6:
                            ActionsOnMap.AddObject(new Point(i, j), map, new Hyena()); 
                            break;
                        case 7:
                            ActionsOnMap.AddObject(new Point(i, j), map, new Tiger()); 
                            break;
                        case 8:
                            ActionsOnMap.AddObject(new Point(i, j), map, new Wolf()); 
                            break;
                        }
                    }
            }    
        }  
        private int GenerateRandPrey()
        {   
            int generatedValue = RandomValue.Next(1, 5);
            return generatedValue;      
        } 
         private int GenerateRandPredator()
        {   
            int generatedValue = RandomValue.Next(4, 9);
            return generatedValue;      
        }  
        private void GenerateGrass(int x, int y)
        {  
            int k = 0; bool ex = true;
            for(int i = y; i < y + 13; i++) 
            {
                for(int j = x - k; j <= x + k; j++) 
                {
                    var grass = new Grass();
                    grass.Coordinate = new Point(j, i);
                    ActionsOnMap.AddObject(grass.Coordinate, map, grass);
                    
                }
                                    
                
                if(k == 6) ex = false;
                if(ex) k++;
                else k--;
            }   
        }   
     
    }
}


