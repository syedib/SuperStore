using System;
using System.Collections.Generic;
using System.Text;

namespace SuperStore
{
    public static class DiscountFactory
    {
        public static ProductDiscount GetDiscount(DiscountCategory discountCategory, Product product)
        {
            if (discountCategory == DiscountCategory.EMPLOYEE_DISCOUNT)
            {
                return new DiscountForEmployee(product);
            }
            else if (discountCategory == DiscountCategory.SENIOR_CITIZEN_DISCOUNT)
            {
                return new DiscountForSeniorCitizen(product);
            }
            else if (discountCategory == DiscountCategory.CHIPS_CATEGORY_DISCOUNT)
            {
                return new DiscountForChips(product);
            }

            return null;
        }
    }
}
