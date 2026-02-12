namespace MAUIDamageCalculator
{
    
    
        internal class SwordDamage
        {
            private const int BASE_DAMAGE = 3;
            private const int FLAME_DAMAGE = 2;

            //fields of the class
            public int Roll;
            public decimal MagicMultiplier = 1M;
            public int Damage;  //why we didn't initialize it here?
            public int flameDamage = 0; //=0 by default

        public void CalculateDamage() //==============================
            {
                Damage = ((int)(Roll * MagicMultiplier) + BASE_DAMAGE) + flameDamage;  //I put the two prantheses to make sure the order of operations is correct
        }
            public void SetMagic(bool isMagic) //=============================
            {
                if (isMagic)
                {
                    MagicMultiplier = 1.75M;
                }
                else
                {
                    MagicMultiplier = 1M;
                }
                CalculateDamage(); //assign the new MagicMultiplier value to it 

            }
            public void SetFlaming(bool isFlaming) //=========================
            {
                CalculateDamage();
                if (isFlaming)
                {
                flameDamage = FLAME_DAMAGE;   //This is my soulutuion to this thing 
                }


            }




        
    }

}
