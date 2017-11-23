using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace surfm.yoar.poker {
    public class CardInfo {
        public CardNum num { get; private set; }
        public Flower flower { get; private set; }

        public CardInfo(Flower f, CardNum n) {
            num = n;
            flower = f;
        }

        public string prefabPath() {
            string temp = "{0}/{1}_{2}";
            return string.Format(temp,FlowerF.g(flower).prefabPath(),flower.ToString());
        }


        public string uid() {
            return getUid(flower,num);
        }

        public static string getUid(Flower f,CardNum c) {
            return f.ToString() + c.ToString();
        }



    }
}