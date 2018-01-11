using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace surfm.yoar.poker {
    public class SimpleHolder : CardHolder {

        public Card.State state = Card.State.Bright;
        public bool autoSetData = true;

        void Start() {
            if (autoSetData) {
                init();
            }
        }

        public void init() {
            if (current != null) return;
            set(data, null);
            current.setState(state);
        }

        internal override bool findExist(Card d) {
            return false;
        }
    }
}
