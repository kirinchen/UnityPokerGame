using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace surfm.yoar.poker {
    public class Card : MonoBehaviour {

        public CardInfo info { get; private set; }

        internal void init(CardInfo i) {
            info = i;
        }


    }
}
