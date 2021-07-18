                                                Shopbridge API Documentation

Request Type    -  GET
Description     -  Get all articles from database
Request         -  localhost:5000/gaa
Response        - {
                    "status": 200,
                    "articleCount": 2,
                    "articleData": [
                        {
                            "id": 1,
                            "code": "sdfuh57838f84",
                            "name": "Nescafe Coffee - 50 Gram",
                            "description": "50 Gram Nescafe Coffee",
                            "price": 50,
                            "count": 500,
                            "createddDate": "2021-07-18T17:05:09.177785",
                            "updatedDate": "2021-07-18T17:05:09.177785"
                        },
                        {
                            "id": 2,
                            "code": "sdfuh5722238f84",
                            "name": "Green Tea - 50 Gram",
                            "description": "50 Gram Green Tea",
                            "price": 600,
                            "count": 500,
                            "createddDate": "2021-07-18T17:05:09.177785",
                            "updatedDate": "2021-07-18T17:05:09.177785"
                        }
                    ]
                }
-----------------------------------------------------------------------------------------------------------------------------------------------

Request Type    -  GET
Description     -  Get article by id from database
Request         -  localhost:5000/gabi?id=1
Response        - {
                        "status": 200,
                        "articleData": {
                            "id": 1,
                            "code": "sdfuh57838f84",
                            "name": "Nescafe Coffee - 50 Gram",
                            "description": "50 Gram Nescafe Coffee",
                            "price": 50,
                            "count": 500,
                            "createddDate": "2021-07-18T17:05:09.177785",
                            "updatedDate": "2021-07-18T17:05:09.177785"
                        }
                    }
-----------------------------------------------------------------------------------------------------------------------------------------------

Request Type    -  POST
Description     -  Create new article
Request         -  localhost:5000/ca
Request JSON    -   {
                        "code" : "sdfuh52138f84",
                        "name" : "Maggie Noodles - 30 Gram",
                        "description" : "Nestle Maggie Noodles - 30 Gram",
                        "price" : 12,
                        "count" : 500
                    }
Response        -   {
                        "status": 200,
                        "articleId": 4
                    }
-----------------------------------------------------------------------------------------------------------------------------------------------

Request Type    -  PUT
Description     -  Update existing article
Request         -  localhost:5000/ua
Request JSON    -   {
                        "code" : "sdfuh52138f84",
                        "name" : "Maggie Noodles - 30 Gram",
                        "description" : "Nestle Maggie Noodles - 30 Gram",
                        "price" : 12,
                        "count" : 1000
                    }
Response        -   {
                        "status": 200,
                        "objArticle": {
                            "id": 4,
                            "code": "sdfuh52138f84",
                            "name": "Maggie Noodles - 30 Gram",
                            "description": "Nestle Maggie Noodles - 30 Gram",
                            "price": 12,
                            "count": 1000,
                            "createddDate": "0001-01-01T00:00:00",
                            "updatedDate": "2021-07-18T11:58:51.7569249Z"
                        }
                    }
-----------------------------------------------------------------------------------------------------------------------------------------------

Request Type    -  DELETE
Description     -  Delete existing article by id
Request         -  localhost:5000/dabi?id=4
Response        -   {
                        "status": 200
                    }
-----------------------------------------------------------------------------------------------------------------------------------------------