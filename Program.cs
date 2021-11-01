using System;
//try      try
namespace SoftwareTeamXiangQi
{
    class Program
    {

        public abstract class Chess{
            public int xCoordinate = 0;
            public int yCoordinate = 0;
        
            public Chess(int xCoordinate,int yCoordinate){
                this.xCoordinate = xCoordinate;
                this.yCoordinate = yCoordinate;
            }
         
       }
 
        public class  King: Chess //将
        {    public King(int xCoordinate, int yCoordinate)
            : base(xCoordinate, yCoordinate)
             {}
         }

        public class  Rook: Chess //车
        {    public Rook(int xCoordinate, int yCoordinate)
            : base(xCoordinate, yCoordinate)
             {}
        }

        public class  Horse: Chess //马
        {    public Horse(int xCoordinate, int yCoordinate)
            : base(xCoordinate, yCoordinate)
             {}
        }

        public class  Elephant: Chess //象
        {    public Elephant(int xCoordinate, int yCoordinate)
            : base(xCoordinate, yCoordinate)
             {}
        }

        public class  Guard: Chess //士
        {    public Guard(int xCoordinate, int yCoordinate)
            : base(xCoordinate, yCoordinate)
             {}
        }
   
        public class  Cannons: Chess //炮
        {    public Cannons(int xCoordinate, int yCoordinate)
            : base(xCoordinate, yCoordinate)
             {}
        }

        public class  Soldier: Chess //兵卒
        {    public Soldier(int xCoordinate, int yCoordinate)
            : base(xCoordinate, yCoordinate)
             {}
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, here is our game!");

        }
    }
}
