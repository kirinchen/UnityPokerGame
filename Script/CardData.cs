using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace surfm.yoar.poker {

    [System.Serializable]
    public class CardData {
        [JsonConverter(typeof(StringEnumConverter))]
        public CardNum num;
        [JsonConverter(typeof(StringEnumConverter))]
        public Flower flower;

        public static string getUid(Flower f, CardNum c) {
            return f.ToString() + c.ToString();
        }

        internal string getUid() {
            return getUid(flower, num);
        }

        public static CardData c(_CD cc) {
            CardData ans = new CardData();
            ans.flower = cc.flower;
            ans.num = cc.num;
            return ans;
        }
    }

    public struct _CD {
        public CardNum num;
        public Flower flower;
    }
}
