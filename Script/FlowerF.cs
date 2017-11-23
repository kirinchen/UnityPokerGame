using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace surfm.yoar.poker {
    public class FlowerF {

        private static Dictionary<Flower, FlowerF> map = new Dictionary<Flower, FlowerF>();

        private Flower f;

        private FlowerF(Flower f) {
            this.f = f;
        }

        public string prefabPath() {
            return "@Card" + f.ToString();
        }


        public static FlowerF g(Flower gf) {
            if (!map.ContainsKey(gf)) {
                map.Add(gf, new FlowerF(gf));
            }
            return map[gf];
        }

    }

    public enum Flower {
        Spades, Heart, Diamond, Club
    }
}
