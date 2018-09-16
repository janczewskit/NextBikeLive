# NextBikeLive
NextBike Api wrapper for C#. Wrapping and mapping from json data (https://nextbike.net/maps/nextbike-live.json) to C# object class hierarchy.

# Code structure
* NextBikeClient - client based on System.Net.WebClient to get json data from server
* NextBikeDao - dao gives access to data mapped to C# object class hierarchy
* NextBike - root data model

# Data structure
* NextBike
  * Countries
    * Latitude
    * Longitude
    * Zoom
    * Name
    * Hotline
    * Domain
    * Language
    * Email
    * Timezone
    * Currency
    * CountryCallingCode
    * SystemOperatorAddress
    * CountryCode
    * CountryName
    * Terms
    * Policy
    * Website
    * ShowBikeTypes
    * ShowBikeTypeGroups
    * ShowFreeRacks
    * BookedBikes
    * SetPointBikes
    * AvailableBikes
    * CappedAvailableBikes
    * Pricing
    * Cities
      * Id
      * Latitude
      * Longitude
      * Zoom
      * MapIcon
      * Alias
      * Break
      * Name
      * NumPlaces
      * RefreshRate
      * Bounds
        * Key
        * MapPoint
          * Latitude
          * Longitude
      * BookedBikes
      * SetPointBikes
      * AvailableBikes
      * ReturnToOfficialOnly
      * BikeTypes
      * Places
        * Id
        * Latitude
        * Longitude
        * Bike
        * Name
        * Address
        * Spot
        * Number
        * BikesCount
        * BikeRacks
        * FreeRacks
        * Maintenance
        * TerminalType
        * Bikes
	        * Number
	        * Type
	        * LockTypes
	        * Active
	        * State
	        * HasElectricLock
	        * BoardComputer
        * BikeNumbers
        * BikeTypes
        * Type
        * RackLocks
        * NoRegistration
