using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace surfm.yoar.poker {
    public class PokerConfig : MonoBehaviour {

        private static PokerConfig instance;

        public Card cardPrefab;

        internal Card instantiateCard() {
            return Instantiate(cardPrefab);
        }

        public static PokerConfig getInstance() {
            if (instance == null) {
                instance = FindObjectOfType<PokerConfig>();
            }
            return instance;
        }


    }
}
