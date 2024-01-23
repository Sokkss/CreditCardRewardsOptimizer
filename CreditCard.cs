using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCardRewardsOptimizer
{
    public class CreditCard
    {
        string name { get; set; }

        string company { get; set; }

        string? welcomeBonus { get; set; }

        int? groceryRewardsRate { get; set; }

        int? restaurantRewardsRate { get; set; }

        int? takeoutRewardsRate { get; set; }

        int? streamingServicesRewardsRate { get; set; }

        int? targetRewardsRate { get; set; }

        int? drugstoreRewardsRate { get; set; }

        int? lyftRewardsRate { get; set; }

        int? airTravelRewardsRate { get; set; }

        int? hotelRewardsRate { get; set; }

        int? gasStationRewardsRate { get; set; }

        int? gymMembershipRewardsRate { get; set; }

        int? everythingElseRewardsRate { get; set; }

        public CreditCard(
            string name, 
            string company, 
            string? welcomeBonus, 
            int? groceryRewardsRate,
            int? restaurantRewardsRate,
            int? takeoutRewardsRate,
            int? streamingServicesRewardsRate,
            int? targetRewardsRate,
            int? drugstoreRewardsRate,
            int? lyftRewardsRate,
            int? airTravelRewardsRate,
            int? hotelRewardsRate,
            int? gasStationRewardsRate,
            int? gymMembershipRewardsRate,
            int? everythingElseRewardsRate)
        {
            this.name = name;
            this.company = company;
            this.welcomeBonus = welcomeBonus;
            this.groceryRewardsRate = groceryRewardsRate;
            this.restaurantRewardsRate = restaurantRewardsRate;
            this.takeoutRewardsRate = takeoutRewardsRate;
            this.streamingServicesRewardsRate = streamingServicesRewardsRate;
            this.targetRewardsRate = targetRewardsRate;
            this.drugstoreRewardsRate = drugstoreRewardsRate;
            this.lyftRewardsRate = lyftRewardsRate;
            this.airTravelRewardsRate = airTravelRewardsRate;
            this.hotelRewardsRate = hotelRewardsRate;
            this.gasStationRewardsRate = gasStationRewardsRate;
            this.gymMembershipRewardsRate = gymMembershipRewardsRate;
            this.everythingElseRewardsRate = everythingElseRewardsRate;
        }
    }
}
