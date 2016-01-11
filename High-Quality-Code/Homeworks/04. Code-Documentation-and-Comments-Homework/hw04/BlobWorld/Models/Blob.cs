namespace BlobWorld.Models
{
    using System;
    using BlobWorld.Enums;

    public class Blob
    {
        private string name;
        private int intialHealth;
        private int health;
        private int intialDamage;
        private int damage;
        private Behaviors behavior;
        private Attacks attack;
        private State state;
        private BehaviorState behaviorState;//0 -not activated, 1 activated
        public int turn = 0;

        public Blob(string name, int health, int damage, Behaviors behavior, Attacks attack, State state=State.ALIVE, BehaviorState behaviorState= BehaviorState.notactivated)
        {
            this.Name = name;
            this.IntialHealth = health;
            this.Health = health;
            this.IntialDamage = damage;
            this.Damage = damage;
            this.Behavior = behavior;
            this.Attack = attack;
            this.State = state;
            this.BehaviorState = behaviorState;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be null or empty.");
                }
                this.name = value;
            }
        }
        public int IntialHealth
        {
            get
            {
                return this.intialHealth;
            }

            private set
            {
                this.intialHealth = value;
            }
        }
        public int Health
        {
            get
            {
                return this.health;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Health can be only positive.");
                }
                this.health = value;
            }
        }
        public int IntialDamage
        {
            get
            {
                return this.intialDamage;
            }

            private set
            {
                this.intialDamage = value;
            }
        }
        public int Damage
        {
            get
            {
                return this.damage;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Damage can be only positive.");
                }
                this.damage = value;
            }
        }
        public Behaviors Behavior
        {
            get
            {
                return this.behavior;
            }

            private set
            {
                this.behavior = value;
            }
        }
        public Attacks Attack
        {
            get
            {
                return this.attack;
            }

            private set
            {
                this.attack = value;
            }
        }
        public State State
        {
            get
            {
                return this.state;
            }

            set
            {
                this.state = value;
            }
        }
        public BehaviorState BehaviorState
        {
            get
            {
                return this.behaviorState;
            }

            set
            {
                this.behaviorState = value;
            }
        }
    }
}
