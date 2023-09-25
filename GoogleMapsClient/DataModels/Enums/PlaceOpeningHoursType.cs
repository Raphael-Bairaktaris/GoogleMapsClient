﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleMapsClient
{
    /// <summary>
    /// Provides enumeration of opening hours
    /// </summary>
    public enum PlaceOpeningHoursType
    {
        /// <summary>
        /// Drive through
        /// </summary>
        DriveThrough = 0,

        /// <summary>
        /// Happy hour
        /// </summary>
        HappyHour = 1,

        /// <summary>
        /// Delivery
        /// </summary>
        Delivery = 2,

        /// <summary>
        /// Takeout
        /// </summary>
        Takeout = 3,

        /// <summary>
        /// Kitchen
        /// </summary>
        Kitchen = 4,

        /// <summary>
        /// Breakfast
        /// </summary>
        Breakfast = 5,

        /// <summary>
        /// Lunch
        /// </summary>
        Lunch = 6,

        /// <summary>
        /// Dinner
        /// </summary>
        Dinner = 7,

        /// <summary>
        /// Brunch
        /// </summary>
        Brunch = 8,

        /// <summary>
        /// Pickup
        /// </summary>
        Pickup = 9,

        /// <summary>
        /// SeniorHours
        /// </summary>
        SeniorHours = 10
    }
}