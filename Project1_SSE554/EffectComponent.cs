using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_SSE554
{
    public abstract class EffectComponent
    {
        public void addEffect(EffectComponent effectComponent)
        {
            throw new NotImplementedException();
        }

        public void removeEffect(EffectComponent effectComponent)
        {
            throw new NotImplementedException();
        }

        public int getEffectTime()
        {
            throw new NotImplementedException();
        }

        public List<string> getAllEffectDescription()
        {
            throw new NotImplementedException();
        }
        public string getEffectDescription()
        {
            throw new NotImplementedException();
        }
    }

    public class EffectItem : EffectComponent
    {
        string nameOfEffect;
        int effectTime;

        public EffectItem(string newNameOfEffect, int newEffectTime)
        {
            this.nameOfEffect = newNameOfEffect;
            this.effectTime = newEffectTime;
        }

        public new int getEffectTime()
        {
            return effectTime;
        }

        public new string getEffectDescription()
        {
            return "The potion is " + nameOfEffect + " and lasts for " + effectTime + " turn(s)";
        }
    }

    public class Effect : EffectComponent
    {
        List<EffectComponent> allEffectsActive = new List<EffectComponent>();
        string nameOfEffect;

        public Effect(string newNameOfEffect)
        {
            this.nameOfEffect = newNameOfEffect;
        }

        public new void addEffect(EffectComponent effectComponent)
        {
            allEffectsActive.Add(effectComponent);
        }

        public new void removeEffect(EffectComponent effectComponent)
        {
            allEffectsActive.Remove(effectComponent);
        }

        public new List<string> getAllEffectDescription()
        {
            List<string> typeWithDescription = new List<string>();
            for(int x =0; x < allEffectsActive.Count(); x++)
            {
                typeWithDescription.Add(nameOfEffect + " - " + allEffectsActive[x].getEffectDescription());
            }

            return typeWithDescription;
        }
    }
}
