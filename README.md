# API documentation

 * `LocationId` indexes the board from 0 - 39, where 0 is GO. 
 * `Hours` is the value to deduct in the central hub.

## GET /api/v1/properties/1

    {
     "Id: 1",
     "LocationId": 1,
     "Hours: 60
    }

## GET /api/v1/properties

    [
      {
        "Id": 1,
        "LocationId": 1,
        "Hours": 60
      },
      {
         "Id": 2,
         "LocationId": 3,
         "Hours": 60
      },
      {
         "Id: 3",
         "LocationId": 5,
         "Hours": 200
      },
      {
          "Id": 5,
          "LocationId": 8,
          "Hours": 100
      },
      ...
    ]
    
