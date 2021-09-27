using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Reflection.Emit;
using System.Threading.Tasks;
using FootballPLayer;

namespace RestService
{
    public class Manager
    {
       
        private static int NextId = 1;

        public readonly static List<FootballPlayer> FP = new List<FootballPlayer>()
        {
            new FootballPlayer(NextId++, "Christiano Ronaldo", 750, 7),
            new FootballPlayer(NextId++, "Lionel Messi", 750, 31),
            new FootballPlayer(NextId++, "Andre Silva", 750, 11)
        };

        public List<FootballPlayer> GetAll()
        {
            return new List<FootballPlayer>(FP);
        }

        public FootballPlayer GetByID(int id)
        {
            return FP.Find(fp => fp.Id == id);
        }

   
        public FootballPlayer Add(FootballPlayer NewPlayer)
        {
            NewPlayer.Id = NextId++;
            FP.Add(NewPlayer);
            return NewPlayer;
        }

        public FootballPlayer Update(int id, FootballPlayer Updates)
        {
            FootballPlayer player = FP.Find(FP => FP.Id == id);
            if (player == null)
            {
                return null;
            }
            player.Id = Updates.Id;
            player.Name = Updates.Name;
            player.Price = Updates.Price;
            player.ShirtNumber = Updates.ShirtNumber;

            return player;
        }

        public FootballPlayer Delete(int id)
        {
            FootballPlayer fp = FP.Find(FP => FP.Id == id);
            if (fp == null)
            {
                return null;
            }
            FP.Remove(fp);
            return fp;
        }
    }
}
