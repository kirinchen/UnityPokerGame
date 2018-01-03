using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace surfm.yoar.poker {
    public class FlowerF {

        private static Dictionary<Flower, FlowerF> map = new Dictionary<Flower, FlowerF>();

        public Flower f { get; private set; }

        private FlowerF(Flower f) {
            this.f = f;
        }

        public string prefabDirPath() {
            return "@Card/" + f.ToString() + "s";
        }


        public static FlowerF g(Flower gf) {
            if (!map.ContainsKey(gf)) {
                map.Add(gf, new FlowerF(gf));
            }
            return map[gf];
        }

        internal static Flower random() {
            return (Flower)UnityEngine.Random.Range(0, 4);
        }
    }

    public enum Flower {
        NONE, Spade, Heart, Diamond, Club
    }
}
