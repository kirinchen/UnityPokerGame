using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace surfm.yoar.poker {
    public class CardSpriteRender : Card {

        public GameObject body { get; private set; }
        private Vector3 orgRot;

        internal override void init(CardInfo i, object target) {
            string p = i.prefabPath();
            GameObject g = Resources.Load<GameObject>(p);
            Debug.Log("p=" + p + " g=" + g);
            body = Instantiate(g, transform, false);
            orgRot = body.transform.localEulerAngles;
            base.init(i, target);
        }

        internal override void renderByState(State s) {
            switch (s) {
                case State.Bright:
                    setActive(true);
                    body.transform.localEulerAngles = new Vector3(orgRot.x, orgRot.y + 180, orgRot.z);
                    break;
                case State.Cover:
                    body.transform.localEulerAngles = orgRot;
                    setActive(true);
                    break;
                case State.Hide:
                    setActive(false);
                    break;
            }
        }

        private void setActive(bool v) {
            if (v == body.activeSelf) return;
            body.SetActive(v);
        }
    }
}
