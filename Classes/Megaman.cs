namespace Megaman_Polymorphism.Classes
{
    public class Megaman : Player
    {

        
        
        
        public override string Run()
        {

            speed = 40;

            return $"Megaman runs with speed = {speed}";
        
        }

        public override string Jump()
        {

            return $"Megaman jumps with force = {jumpForce}";
        
        }


        public override string Attack()
        {

            return $"Megaman attacks with strength = {strength}";
            
        }


    }
}