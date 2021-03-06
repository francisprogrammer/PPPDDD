﻿using System;
using System.Collections.Generic;
using PPPDDDChap19.eBidder.Listings.Application.Infrastructure;

namespace PPPDDDChap19.eBidder.Listings.Model.Auctions
{
    public class Offer : ValueObject<Offer>
    {
        public Offer(Guid bidderId, Money maximumBid, DateTime timeOfOffer)
        {
            if (bidderId == Guid.Empty)
                throw new ArgumentNullException("BidderId cannot be null");

            if (maximumBid == null)
                throw new ArgumentNullException("MaximumBid cannot be null");

            if (timeOfOffer == DateTime.MinValue)
                throw new ArgumentNullException("Time of Offer must have a value");

            Bidder = bidderId;
            MaximumBid = maximumBid;
            TimeOfOffer = timeOfOffer;
        }

        public Guid Bidder { get; private set; }
        public Money MaximumBid { get; private set; }
        public DateTime TimeOfOffer { get; private set; }
       
        protected override IEnumerable<object> GetAttributesToIncludeInEqualityCheck()
        {
            return new List<Object>()
            {
                Bidder, MaximumBid, TimeOfOffer
            };
        }
    }   
}
