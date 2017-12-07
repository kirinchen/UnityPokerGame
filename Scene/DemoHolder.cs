using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace surfm.yoar.poker {
    public class DemoHolder : CardHolder {

        void Start() {
            set(data, null);
            current.setState(Card.State.Bright);
        }

        internal override bool findExist(Card d) {
            return string.Equals(d.info.uid(), data.getUid());
        }
    }
}
