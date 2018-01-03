using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace surfm.yoar.poker {
    public class SimpleHolder : CardHolder {

        public Card.State state = Card.State.Bright;

        void Start() {
            set(data, null);
            current.setState(state);
        }

        internal override bool findExist(Card d) {
            return string.Equals(d.info.uid(), data.getUid());
        }
    }
}
