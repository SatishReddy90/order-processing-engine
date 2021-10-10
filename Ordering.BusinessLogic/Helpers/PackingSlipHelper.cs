using Ordering.BusinessLogic.Exceptions;
using Ordering.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.BusinessLogic.Helpers
{
    public class PackingSlipHelper
    {
        public static PackingSlip GeneratePackingSlipForShipping(Order order)
        {
            if (order == null)
            {
                throw new PackingSlipGenerationException("Packing slip can't be generated for invalid order.");
            }

            var packingSlip = GeneratePackingSlip();
            // modify the obj as per shipping requirements
            return packingSlip;
        }

        public static PackingSlip GeneratePackingSlipForRoyaltyDepartment(Order order)
        {
            if (order == null)
            {
                throw new PackingSlipGenerationException("Packing slip can't be generated for invalid order.");
            }

            var packingSlip = GeneratePackingSlip();
            // log error occured while generating the packing slip for shipping.
            return packingSlip;
        }

        private static PackingSlip GeneratePackingSlip()
        {
            // perform generation logic and return genrated packing slip
            return new PackingSlip();
        }
    }
}
