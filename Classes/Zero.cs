namespace Megaman_Polymorphism.Classes
{
    public class Zero : Player
    {
        
      
    

        
      public override string Run() {

           return $"Zero runs with speed = {speed}";

        }

      public override string Jump() {

         jumpForce = 30;
         
         return $"Zero jumps with force = {jumpForce}";

        }

      public override string Attack() {

         strength = 20;


         return $"Zero attacks with strength = {strength}";

        }
    
    
    
    }
}