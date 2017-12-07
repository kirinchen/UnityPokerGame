using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace surfm.yoar.poker {
    public class CardUtils {

        private static Dictionary<string, CardInfo> infoMap = new Dictionary<string, CardInfo>();

        internal static CardInfo getInfo(CardData d) {
            string k = d.getUid();
            if (!infoMap.ContainsKey(k)) {
                CardInfo ci = new CardInfo(d);
                infoMap.Add(k, ci);
            }
            return infoMap[k];
        }

        internal static Card genCard(CardData d,object tar) {
            CardInfo ci = getInfo(d);
            Card ans = PokerConfig.getInstance().instantiateCard();
            ans.init(ci, tar);
            return ans;
        }

    }
}
