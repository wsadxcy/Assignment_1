using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment_1
{
    /**
     * This class define a Hero
     * 
     * @class Hero
     */
    class Hero
    {
        // PRIVATE INSTANCE VARIABLES=====================================================
        private string _name;
        private int _strength;
        private int _speed;
        private int _health;

        // PUBLIC PROPERTIES==============================================================
        /**
         * This is a public property for private _name field
         * 
         * @property {string} Name
         */
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        // CONSTRUCTORS +++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * This is the default empty constructor for the Hero class
         * </summary>
         * 
         * @constructor Hero
         */
         public Hero()
        {
            this.Name = "Unknown Name";
            _generateAbilities();
            
        }  
        // PRIVATE METHODS===================================================================
        private void _generateAbilities()
        {
            Random random = new Random();
           
            _strength = random.Next(1,100);
            _speed = random.Next(1,100);
            _health = random.Next(1,100);

            
        }

        private bool _hitAttempt()
        {
            bool hit = false;
            Random random = new Random();
            int HitAtp = random.Next(4);
            
            if(HitAtp == 0)
            {
                hit = true;
            }
            return hit;


        }

        private int _hitDamage()
        {
            Random random = new Random();
            int DamMult = random.Next(1, 6);
            
            int FinDam = DamMult * _strength;
            return FinDam;
        }

        //PUBLIC METHODS====================================================================
        public void Fight()
        {
            bool hit = _hitAttempt();
            if
                (hit == true)
            {
                
                Console.WriteLine("Deals"+_hitDamage()+"Damage");
            }
            
        }
        public void Show()
        {
            Console.WriteLine(this.Name+"Strength = "+_strength+"Speed = "+_speed+"Health = "+_health);
        }
    }
}
