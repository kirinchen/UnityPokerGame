using surfm.tool;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace surfm.yoar.poker {
    public class CardInfo {
        public CardNumF num { get { return CardNumF.g(data.num); } }
        public FlowerF flower { get { return FlowerF.g(data.flower); } }
        public CardData data { get; private set; }
        private GameObject dbObj = null;

        public CardInfo(CardData d) {
            data = d;
        }

        public string prefabPath() {
            string temp = "{0}/{1}_{2}";
            return string.Format(temp, flower.prefabDirPath(), flower.f.ToString(), num.getName());
        }

        public GameObject readObj() {
            if (dbObj != null) return dbObj;
            string p = prefabPath();
            return Resources.Load<GameObject>(p);
        }

        public SpriteRenderer getFrontRenderer() {
            return UnityUtils.getComponentByName<SpriteRenderer>(readObj(), "Front");
        }

        public SpriteRenderer getBackRenderer() {
            return UnityUtils.getComponentByName<SpriteRenderer>(readObj(), "Back");
        }



        public string uid() {
            return data.getUid();
        }

    }
}