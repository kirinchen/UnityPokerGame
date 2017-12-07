using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace surfm.yoar.poker {
    public abstract class Card : MonoBehaviour {

        public enum State {
            Bright, Cover, Hide
        }

        public object target { get; private set; }
        public CardInfo info { get; private set; }
        public State state { get; private set; }
        public bool inited { get; private set; }

        internal virtual void init(CardInfo i, object t) {
            target = t;
            info = i;
            setState(State.Hide);
            inited = true;
        }

        public virtual void setState(State s) {
            if (state == s && inited) return;
            state = s;
            renderByState(s);
        }

        internal void setPrent(Transform t) {
            transform.SetParent(t, false);
        }

        internal abstract void renderByState(State s);
    }
}
