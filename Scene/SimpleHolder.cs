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

        public bool init() {
            if (current != null) return false;
            set(data, null);
            current.setState(state);
            return true;
        }

        internal override bool findExist(Card d) {
            return false;
        }

        internal void setState(Card.State s) {
            state = s;
            if (!init()) {
                current.setState(s);
            }

        }
    }
}
