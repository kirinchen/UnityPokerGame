using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace surfm.yoar.poker {
    public class CardUtils {

        private static Dictionary<string, CardInfo> infoMap = new Dictionary<string, CardInfo>();

        public static CardInfo getInfo(Flower f, CardNum n) {
            string k = CardInfo.getUid(f, n);
            if (!infoMap.ContainsKey(k)) {
                CardInfo ci = new CardInfo(f, n);
                infoMap.Add(k, ci);
            }
            return infoMap[k];
        }

        public static Card getCard(Flower f, CardNum n) {
            CardInfo ci = getInfo(f,n);
            GameObject go = Resources.Load<GameObject>(ci.prefabPath());
            Card ans = go.AddComponent<Card>();
            ans.init(ci);
            return ans;
        }

    }
}
