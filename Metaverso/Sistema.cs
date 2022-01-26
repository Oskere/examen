namespace Metaverso
{
    public class Sistema
    {
        
        public string metaverso(int num){
            if (num%5==0 ){
                if (num % 3==0){
                    return "Metaverso";
                }
                return "Verso";
            } else if (num%3==0){
                return "Meta";
            } 
            return numero.ToString();
        }
        public string metaverso(int[] nums){
           string resultado="";
           foreach(int num in nums){
               resultado+=metaverso(num);
           } 
           return resultado;
        }
    }
}
