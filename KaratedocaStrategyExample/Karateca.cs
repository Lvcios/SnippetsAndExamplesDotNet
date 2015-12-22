using KaratedocaStrategyExample.Behaviors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaratedocaStrategyExample
{
    public class Karateca
    {
        public IAttackBehavior _attack ;
        public IDefenseBehavior _defense ;
        public IMovementBehavior _movement ;
        public IPositionBehavior _position ;
        public ISpeakBehavior _speak ;
        public IStrategyBehavior _strategy ;
        public IKiaBehavior _kia ;

        public IAttackBehavior AttackTechnique
        {
            get { return _attack; }
            set { _attack = value; }
        }

        public IDefenseBehavior DefenseTechnique
        {
            get { return _defense; }
            set { _defense = value; }
        }

        public IMovementBehavior Movement
        {
            get { return _movement; }
            set { _movement = value; }
        }

        public IPositionBehavior Position
        {
            get { return _position; }
            set { _position = value; }
        }

        public ISpeakBehavior Speak
        {
            get { return _speak; }
            set { _speak = value; }
        }

        public IStrategyBehavior Strategy
        {
            get { return _strategy; }
            set { _strategy = value; }
        }

        public IKiaBehavior Kia
        {
            get { return _kia; }
            set { _kia = value; }
        }

        public Karateca()
        {
            
        }

        public void Attack()
        {
            _attack.DoAttack();
        }

        public void Defense()
        {
            _defense.DoDefense();
        }

        public void Move()
        {
            _movement.DoMovement();
        }

        public void SpeakSomething(string _word)
        {
            _speak.Speak(_word);
        }

        public void Scream()
        {
            _kia.DoKia();
        }

        public void DoPosition()
        {
            _position.DoPosition();
        }
    }
}
