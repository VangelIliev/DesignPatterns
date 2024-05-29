using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    public abstract class Character
    {
        protected IInteractionBehaviour _interactionBehaviour;

        public Character(IInteractionBehaviour behaviour)
        {
            this._interactionBehaviour = behaviour;
        }

        public abstract void Move();

        public virtual void Interact()
        {
            if(_interactionBehaviour != null) 
            {
                _interactionBehaviour.Interact();
            }
        }
    }
}
