using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_HandsOn
{
    class ConcreteBuilderChild:Builder
    {
        private Sweets sweet = new Sweets();
        public override void BuildPackageSavory()
        {
            sweet.Add("Savory1");
        
        }

        public override void BuildPackageSweet()
        {
            sweet.Add("Sweet1");
            sweet.Add("Sweet2");
        }

        public override Sweets GetSweets()
        {
            return sweet;
        }
    }
}
