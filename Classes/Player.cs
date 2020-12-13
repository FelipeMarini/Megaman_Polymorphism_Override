namespace Megaman_Polymorphism.Classes
{
    public abstract class Player
    {
        
        public int speed = 20;
        public int jumpForce = 15;
        public int strength = 10;



        public virtual string Run() {

            return $"Running with speed {speed}";
        
        }


        
        public virtual string Jump() {

            return $"Jumping with force {jumpForce}";

        }


        public virtual string Attack() {

            return $"Attacking with strength {strength}";

        }

    }
}