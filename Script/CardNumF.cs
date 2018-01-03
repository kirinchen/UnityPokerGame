using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace surfm.yoar.poker {
    public class CardNumF {

        private static Dictionary<CardNum, CardNumF> map = new Dictionary<CardNum, CardNumF>();

        public CardNum n { get; private set; }
        private CardNumF(CardNum n) {
            this.n = n;
        }

        public string getName() {
            switch (n) {
                case CardNum.N1:
                    return "A";
                case CardNum.N2:
                    return "2";
                case CardNum.N3:
                    return "3";
                case CardNum.N4:
                    return "4";
                case CardNum.N5:
                    return "5";
                case CardNum.N6:
                    return "6";
                case CardNum.N7:
                    return "7";
                case CardNum.N8:
                    return "8";
                case CardNum.N9:
                    return "9";
                case CardNum.N10:
                    return "10";
                case CardNum.J:
                    return "J";
                case CardNum.Q:
                    return "Q";
                case CardNum.K:
                    return "K";
                case CardNum.NONE:
                    return "NONE";
            }
            throw new System.NullReferenceException("not find n=" + n);
        }

        internal static CardNum random() {
            return (CardNum)UnityEngine.Random.Range(1, 14);
        }

        public static CardNumF g(CardNum c) {
            if (!map.ContainsKey(c)) {
                map.Add(c, new CardNumF(c));
            }
            return map[c];
        }

    }

    public enum CardNum {
        NONE, N1, N2, N3, N4, N5, N6, N7, N8, N9, N10, J, Q, K
    }
}
