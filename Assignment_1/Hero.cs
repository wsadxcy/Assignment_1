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
        // PRIVATE METHODS===================================================================
        private void _generateAbilities()
        {
            Random random = new Random();
            int ability = random.Next(100);
        }

        private bool _hitAttempt()
        {
            bool hit = false;
            Random random = new Random();
            int HitAtp = random.Next(4);
            Console.Write(HitAtp);
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
            Console.Write(DamMult);
            return DamMult;
        }

        //PUBLIC METHODS====================================================================
        public void Fight()
        {

        }
        public void Show()
        {

        }
    }
}
