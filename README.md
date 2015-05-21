# API documentation

Properties are indexed by id. The version may change, but other aspects of the URI can be relied upon. Board is indexed from 0 - 39, where 0 is GO.

## GET /api/v1/properties/1

    {
     "Id: 1",
     "Hours: 60
    }

## GET /api/v1/properties

    [
      {
         "Id": 1,
         "Hours": 60
      },
      {
         "Id: 3",
         "Hours: 60
      },
      {
          "Id: 5",
          "Hours: 200
      },
      ...
    ]
    
