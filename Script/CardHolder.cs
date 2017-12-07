using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace surfm.yoar.poker {
    public abstract class CardHolder : MonoBehaviour {

        public CardData data;
        public object target { get; private set; }

        public Card current { get; private set; }


        public virtual void set(CardData cd,object t) {
            data = cd;
            target = t;
            reflesh();
        }

        private void reflesh() {
            if (data == null) return;
            if (current != null) removeCurrent(current);
            current = CardRepo.instance.findOrAddCard(data, target, findExist);
            current.setPrent(transform);
        }

        internal abstract bool findExist(Card d);

        internal virtual void removeCurrent(Card current) {
            current.setState(Card.State.Hide);
            current.setPrent(null);
        }
    }
}
