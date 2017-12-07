using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace surfm.yoar.poker {
    public class CardRepo : MonoBehaviour {

        public static CardRepo instance { get; private set; }
        private List<Card> repo = new List<Card>();

        void Awake() {
            instance = this;
        }

        public Card addCard(CardData d,object tar) {
            Card c =CardUtils.genCard(d,tar);
            repo.Add(c);
            return c;
        }

        internal Card findOrAddCard(CardData data, object tar, Predicate<Card> p) {
            Card c= repo.Find(p);
            if (c != null) return c;
            return addCard(data, tar);
        }
    }
}
