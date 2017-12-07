using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace surfm.yoar.poker {
    public class CardInfo {
        public CardNumF num { get { return CardNumF.g(data.num); } }
        public FlowerF flower { get { return FlowerF.g(data.flower); } }
        public CardData data { get; private set; }

        public CardInfo(CardData d) {
            data = d;
        }

        public string prefabPath() {
            string temp = "{0}/{1}_{2}";
            return string.Format(temp, flower.prefabDirPath(), flower.f.ToString(), num.getName());
        }


        public string uid() {
            return data.getUid();
        }

    }
}