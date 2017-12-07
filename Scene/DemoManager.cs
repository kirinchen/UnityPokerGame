using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace surfm.yoar.poker {
    public class DemoManager : MonoBehaviour {

        public CardHolder cardHolder;


        public void genCard() {
            Card c = CardRepo.instance.addCard(CardData.c(new _CD() {
                flower = Flower.Club,
                num = CardNum.N10
            }), null);
            c.setState(Card.State.Bright);
        }

        public void randomCardHolder() {
            CardData cd = CardData.c(new _CD() {
                flower = FlowerF.random(),
                num = CardNumF.random()
            });
            cardHolder.set(cd, null);
            cardHolder.current.setState(Card.State.Bright);

        }

    }
}
