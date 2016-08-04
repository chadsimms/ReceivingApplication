//*********************************************************************
// Filename: 	    ItemTrans.cs
//
// Description:     This is the ItemTrans Class which defines the 
//                  ItemTrans object found throughout the project.
//
//                      UPC - 12 digit UPC code found on products
//                      amount - quantity of product being accepted
//                      product - name of the product
//                      size - size of the product (2L, 20oz., etc)
//                      cost - cost of the item by case
//                      perCase - the amount of items per case
//
// Author/Designer:	Chad Simms
//**********************************************************************


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS493_Simms_ReceivingApplication.Services
{
    public class ItemTrans
    {
        public string UPC { get; set; }
        public int amount { get; set; }
        public string product { get; set; }
        public string size { get; set; }
        public float cost { get; set; }
        public int perCase { get; set; }
    }
}
